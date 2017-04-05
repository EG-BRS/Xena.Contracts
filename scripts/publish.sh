#!/bin/bash

# Exit script if any errors occure
set -e

# packs the project
dotnet pack ./src/Xena.Contracts/Xena.Contracts.csproj --configuration debug -o nugetPackage

{
  # pushes the pack to nuget.org 
  dotnet nuget push /home/travis/build/EG-Xena/Xena.Contracts/src/Xena.Contracts/nugetPackage/*.nupkg -k "$XENA_CONTRACTS_NUGET_KEY" -s https://www.nuget.org/api/v2/package
} || {
  echo -e "\e[31m An error occured trying to push the package to nuget. Please check that you have updated the version number." 
}
