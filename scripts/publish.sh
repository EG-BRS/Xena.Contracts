#!/bin/bash

# Exit script if any errors occure
set -e

dotnet pack ./src/Xena.Contracts/Xena.Contracts.csproj --configuration debug -o nugetPackage
dotnet nuget push /home/travis/build/EG-Xena/Xena.Contracts/src/Xena.Contracts/nugetPackage/*.nupkg -k 75066627-6f3d-47f6-bd90-b165f912392e -s https://www.nuget.org/api/v2/package


# Anders '  test key 75066627-6f3d-47f6-bd90-b165f912392e'

# husted Xena.Contracts key 086f2040-5566-42ec-857e-2d8753910863
 