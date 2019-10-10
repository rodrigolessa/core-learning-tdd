REM Sets of environments parameters

REM Move to current script folder

cd c:\git\core-learning-tdd

REM Build the entire solution and the testes project and your's dependencies

donet restore

dotnet build

REM Execute test project

cd core.learning.tdd.romanos.test

dotnet test

dotnet publish

nunit3-console.exe bin\Debug\netcoreapp2.2\publish\core.learning.tdd.romanos.test.dll

REM Generates the HTML report

extent TestResult.xml

START TestResult.htm