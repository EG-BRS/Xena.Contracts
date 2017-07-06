def projectName = "Xena.Contracts";
def majorVersion = 1;
def minorVersion = 0;
def buildVersion = env.BUILD_NUMBER;
def version = "$majorVersion.$minorVersion.$buildVersion";

node { 
    stage('Restore') {
        checkout scm

        sh "dotnet restore"
        sh "nuget locals all -list"
        sh "nuget locals all -clear"
        sh "nuget locals all -list"
    }
    stage('Package') {
        if (env.BRANCH_NAME == "master" || env.BRANCH_NAME == "develop") {
            sh "dotnet pack ./src/${projectName}/${projectName}.csproj --configuration debug -o nugetPackage"
        }       
    }    
    stage('Deployment') {
        if (env.BRANCH_NAME == "master" || env.BRANCH_NAME == "develop") {
            sh "dotnet nuget push src/${projectName}/nugetPackage/*.nupkg -k ${XENA_CONTRACTS_NUGET_KEY} -s https://www.nuget.org/api/v2/package"
        }
    }
}
