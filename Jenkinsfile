def projectName = "Xena.Contracts";
def majorVersion = 1;
def minorVersion = 0;
def buildVersion = env.BUILD_NUMBER;
def version = "$majorVersion.$minorVersion.$buildVersion";

node { 
    stage('Restore') {
        checkout scm
     //   sh "dotnet nuget locals --clear global-packages"
     //   sh"dotnet nuget locals –-list all"
        sh "dotnet restore"
    }
    stage('Package') {
        if (env.BRANCH_NAME == "master" || env.BRANCH_NAME == "develop") {
            sh "dotnet pack ./src/${projectName}/${projectName}.csproj --configuration debug -o nugetPackage"
          //  sh"dotnet nuget locals –-list all"
        }       
    }    
    stage('Deployment') {
        if (env.BRANCH_NAME == "master" || env.BRANCH_NAME == "develop") {
            def bla = cat ./src/Xena.Contracts.Xena.Contracts.csproj | grep "(?<=<VersionPrefix>).*(?=<\/VersionPrefix>)"
            sh "dotnet nuget push src/${projectName}/nugetPackage/${bla}.nupkg -k ${XENA_CONTRACTS_NUGET_KEY} -s https://www.nuget.org/api/v2/package"
        }
    }
}
