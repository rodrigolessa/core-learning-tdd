# Execute test project

packages\NUnit.ConsoleRunner.3.10.0\tools\nunit3-console.exe core.learning.tdd.romanos.test\bin\Debug\netcoreapp2.2\core.learning.tdd.romanos.dll

# Generates the HTML report

packages\ReportUnit.1.2.1\tools\ReportUnit.exe TestResult.xml

START TestResult.htm