@ECHO OFF
CLS

..\src\.nuget\nuget Pack iPdfWriter.AspNet.1.0.0.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget 

pause

