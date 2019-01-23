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

	stage('Checkout') {
        echo "Checking out source."
        checkout scm

		echo "Fetching current tags from git"
		withCredentials([[$class: 'UsernamePasswordMultiBinding', credentialsId: 'github_credentials', usernameVariable: 'GIT_USERNAME', passwordVariable: 'GIT_PASSWORD']]) {
            sh("git config user.email ci@codezoo.dk")
            sh("git config user.name 'CI'")
            sh('git fetch --tags https://${GIT_USERNAME}:${GIT_PASSWORD}@github.com/EG-BRS/' + utilityName + '.git' )
        }
    }

    stage('Calculate version') {
		def lastVersion = sh(returnStdout: true, script: "git tag --list '*.*.*' | sort -n | tail -1").trim()
		if (lastVersion == null || lastVersion == '') {
			echo "Did not find any version in git tags, setting last version to 0.0.0"
			lastVersion = '0.0.0'
		} else {
			echo "Last git tag version: ${lastVersion}"
		}

		def (lastVersionMajor, lastVersionMinor, lastVersionPatch) = lastVersion.tokenize( '.' )

		lastVersionMajor = lastVersionMajor as Integer
		lastVersionMinor = lastVersionMinor as Integer
		lastVersionPatch = lastVersionPatch as Integer

		def nextVersionMajor = lastVersionMajor
		def nextVersionMinor = lastVersionMinor
		def nextVersionPatch = lastVersionPatch + 1

		def csproj = readFile csprojPath
		if (csproj != null && csproj.contains('<Version>') && csproj.contains('</Version>')) {
			def csprojVersion = csproj.split('<Version>')[1].split('</Version>')[0]
			def (csprojVersionMajor, csprojVersionMinor, csprojVersionPatch) = csprojVersion.tokenize( '.' )
			csprojVersionPatch = csprojVersionPatch == null || csprojVersionPatch == '' ? '0' : csprojVersionPatch

			csprojVersionMajor = csprojVersionMajor as Integer
			csprojVersionMinor = csprojVersionMinor as Integer
			csprojVersionPatch = csprojVersionPatch as Integer

			if (nextVersionMajor < csprojVersionMajor || (nextVersionMajor == csprojVersionMajor && nextVersionMinor < csprojVersionMinor) || (nextVersionMajor == csprojVersionMajor && nextVersionMinor == csprojVersionMinor && nextVersionPatch < csprojVersionPatch)) {
				echo "Updating next version according to Version in csproj file"
				nextVersionMajor = csprojVersionMajor
				nextVersionMinor = csprojVersionMinor
				nextVersionPatch = csprojVersionPatch
			}
		}
		nextVersion = "${nextVersionMajor}.${nextVersionMinor}.${nextVersionPatch}"
		echo "Next (expected) version: ${nextVersion}"
	}
    
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
        stage('Tag it') {
            echo "Tagging source with tag ${nextVersion}."

            withCredentials([[$class: 'UsernamePasswordMultiBinding', credentialsId: 'github_credentials', usernameVariable: 'GIT_USERNAME', passwordVariable: 'GIT_PASSWORD']]) {
                sh("git config user.email ci@codezoo.dk")
                sh("git config user.name 'CI'")
                sh("git tag -a ${nextVersion} -m 'Jenkins tagged new build'")
                sh('git push https://${GIT_USERNAME}:${GIT_PASSWORD}@github.com/EG-BRS/' + utilityName + '.git --tags')
            }
        }
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
			withCredentials([string(credentialsId: nugetPrivateSourceCredentialsId, variable: 'PRIVATE_APIKEY')]) {
				docker.image(dotnetDockerImage).inside('-e "HOME=/tmp"') {
					sh"""#!/bin/bash -xe
						rm -rf ./nugetPackage
						dotnet pack ${csprojFilename} -c Release -o nugetPackage -p:PackageVersion=${packageVersionFull}
						cd nugetPackage/
						{ 
							dotnet nuget push ${utilityName}.${packageVersion}.nupkg --source ${nugetPrivateSource} --api-key ${PRIVATE_APIKEY}
						} || {
							echo -e "Package version already exists in ${nugetPrivateSource}. Please check git tags and .csproj file"
						}
					"""
					if (env.BRANCH_NAME == "master") {
						withCredentials([string(credentialsId: nugetPublicSourceCredentialsId, variable: 'PUBLIC_APIKEY')]) {
							sh"""#!/bin/bash -xe
								cd nugetPackage/
								{ 
									dotnet nuget push ${utilityName}.${packageVersion}.nupkg --source ${nugetPublicSource} --api-key ${PUBLIC_APIKEY}
								} || {
									echo -e "Package version already exists in ${nugetPublicSource}. Please check git tags and .csproj file"
								}
							"""
						}
					}
				}
			}
		}
	}
}
