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
            sh"""#!/bin/bash -xe
                cd src/Xena.Contracts/nugetPackage/
                curl -F package=@"\$(find -name 'Xena.Contracts.*')" https://${GEMFURY_TOKEN}@push.fury.io/egci/
            """
        }
    }
}
