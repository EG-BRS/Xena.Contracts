def projectName = "Xena.Contracts";
def majorVersion = 1;
def minorVersion = 0;
def buildVersion = env.BUILD_NUMBER;
def version = "$majorVersion.$minorVersion.$buildVersion";

node { 
    stage('Restore') {
        checkout scm
        sh "rm -rf src/${projectName}/nugetPackage"
        sh "dotnet restore"
    }
    stage('Package') {
        if (env.BRANCH_NAME == "master" || env.BRANCH_NAME == "develop") {
            sh "dotnet pack ./src/${projectName}/${projectName}.csproj --configuration debug -o nugetPackage"
        }       
    }    
    stage('Deployment') {
        if (env.BRANCH_NAME == "master" || env.BRANCH_NAME == "develop") {
            sh"""#!/bin/bash -xe
                cd src/${projectName}/nugetPackage/
                { 
                    curl --fail -F package=@"\$(find -name '${projectName}.*')" https://${GEMFURY_TOKEN}@push.fury.io/egci/
                } || {
                    echo -e "Package version already exists. Please increment the version in the .csproj file"
                    exit -1
                }
            """
        }
    }
}
