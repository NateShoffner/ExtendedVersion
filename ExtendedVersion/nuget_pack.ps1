$path = $env:APPVEYOR_BUILD_FOLDER + "\ExtendedVersion\ExtendedVersion.nuspec"
nuget pack $path -Version $env:APPVEYOR_BUILD_VERSION