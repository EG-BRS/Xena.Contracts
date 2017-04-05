#!/bin/bash

# Exit script if any errors occure
set -e

dotnet pack ./src/Xena.Contracts/Xena.Contracts.csproj --configuration debug -o nugetPackage
dotnet nuget push nugetPackage/*.nupkg -k 75066627-6f3d-47f6-bd90-b165f912392e

# Anders '  test key 75066627-6f3d-47f6-bd90-b165f912392e'

# husted Xena.Contracts key 086f2040-5566-42ec-857e-2d8753910863
