def utilityName = "Xena.Contracts";
def utilityPath = "src/${utilityName}"
def csprojFilename = "${utilityName}.csproj"
def csprojPath = "${utilityPath}/${csprojFilename}"
def nugetRestoreSource = "https://nexus.codezoo.io/repository/xena-nuget-group/";
def nugetRestoreSourceConfigFileId = "xena-nuget-group";
def nugetPrivateSource = "https://nexus.codezoo.io/repository/xena-nuget-hosted/";
def nugetPrivateSourceCredentialsId = "xena-nuget-hosted-apikey"
def nugetPublicSource = "https://www.nuget.org/api/v2/package";
def nugetPublicSourceCredentialsId = "xena-nuget-org-apikey"
def dotnetDockerImage = "microsoft/dotnet:2.1-sdk"

node {
	def nextVersion

	cleanWs()

	def buildDetails = checkoutWithDetails(branch:env.BRANCH_NAME, csProjFile: csprojPath)

    
    
	stage('Build') {
		dir(utilityPath) {
			configFileProvider([configFile(fileId: nugetRestoreSourceConfigFileId, variable: 'NUGET_CONFIG')]) {
				docker.image(dotnetDockerImage).inside('-e "HOME=/tmp"') {
					sh"""#!/bin/bash -xe
						dotnet restore ${csprojFilename} --configfile $NUGET_CONFIG --no-cache --source ${nugetRestoreSource}
						dotnet publish -c Release
					"""
				}
			}
		}
    }

	if(env.BRANCH_NAME == "master") {
        tag(buildDetails)
    }

	stage('Pack and Push') {
		def packageVersion
		def packageVersionFull
		if (env.BRANCH_NAME == "master") {
			packageVersion = nextVersion
			packageVersionFull = packageVersion
		} else {
			def gitSHA1 = sh(returnStdout: true, script: "git rev-parse --short HEAD").trim()

			if (env.BRANCH_NAME == "development") {
				packageVersion = "${nextVersion}-beta.${env.BUILD_NUMBER}"
				packageVersionFull = "${packageVersion}+${gitSHA1}"
			} else {
				def datetime = (new Date()).format("yyyyMMddHHmmss")
				def safeBranch = env.BRANCH_NAME.toLowerCase().replaceAll("[^a-z0-9-]", "-")
				packageVersion = "${nextVersion}-alpha.${datetime}"
				packageVersionFull = "${packageVersion}+${safeBranch}.${env.BUILD_NUMBER}.${gitSHA1}"
			}
		}

		echo "Full Package Version: ${packageVersionFull}"

		dir(utilityPath) {
            docker.image(dotnetDockerImage).inside('-e "HOME=/tmp"') {
					sh"""#!/bin/bash -xe
						rm -rf ./nugetPackage
						dotnet pack ${csprojFilename} -c Release -o nugetPackage -p:PackageVersion=${packageVersionFull} --no-restore --no-build
					"""

					pushNuget(utilityName, packageVersion, nugetPrivateSource, nugetPrivateSourceCredentialsId)
					
					if (env.BRANCH_NAME == "master" && nugetPublicSource != "" && nugetPublicSourceCredentialsId != "") {
						pushNuget(utilityName, packageVersion, nugetPublicSource, nugetPublicSourceCredentialsId)
					}
				}
		}
	}
}
