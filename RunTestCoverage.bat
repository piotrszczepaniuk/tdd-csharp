dotnet test  /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=TestResults/Coverage/
call cd TDD.CSharp.Core.Tests
dotnet reportgenerator "-reports:TestResults/Coverage/coverage.cobertura.xml" "-targetDir:TestResults/Coverage/Reports" -reportTypes:htmlInline
pause