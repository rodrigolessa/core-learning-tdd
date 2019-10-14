@echo off

rem @set scriptPath=%~dp0%run-trx-report-core.ps1
rem echo "& '%scriptPath%'"
rem PowerShell -NoProfile -ExecutionPolicy Bypass -noexit -Command "& '%scriptPath%'"

cd C:\git\core-learning-tdd\core.learning.tdd.romanos.test

dotnet build

dotnet test --logger trx;LogFileName=resultados.trx

cd ..

trxer\TrxerConsole.exe core.learning.tdd.romanos.test\TestResults\resultados.trx

cd core.learning.tdd.romanos.test

cd TestResults

START resultados.trx.html

@pause