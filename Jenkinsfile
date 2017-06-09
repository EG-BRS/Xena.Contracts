def projectName = "xena-contracts";
def majorVersion = 1;
def minorVersion = 0;
def buildVersion = env.BUILD_NUMBER;
def version = "$majorVersion.$minorVersion.$buildVersion";

node { 
    stage('Restore') {
        checkout scm
        
        sh "dotnet restore"
    }
    stage('Package') {
        if (env.BRANCH_NAME == "master" || env.BRANCH_NAME == "develop") {
            sh "dotnet pack ./src/Xena.Contracts/Xena.Contracts.csproj --configuration debug -o nugetPackage"
        }       
    }    
    stage('Deployment') {
        if (env.BRANCH_NAME == "master" || env.BRANCH_NAME == "develop") {
            sh """
                PACKAGE="$(find -name 'Xena.Contracts.*')"
                curl -F package=@${PACKAGE} https://${GEMFURY_TOKEN}@push.fury.io/egci/
            """
        }
    }
}
