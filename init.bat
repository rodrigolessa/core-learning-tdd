REM Creating TDD projects

cd c:\git\core-learning-tdd

REM Framework estável
dotnet new globaljson --sdk-version 2.2.108 --force

REM Projeto para regras de negócio do domínio
dotnet new classlib -n core.learning.tdd.romanos -f netcoreapp2.2 -lang C#

REM Projetos para regras de Cálculos de salário dos Funcionários
dotnet new classlib -n core.learning.tdd.financeiro -f netcoreapp2.2 -lang C#

REM Projeto para interface com o banco de dados
dotnet new classlib -n core.learning.tdd.financeiro.repository -f netcoreapp2.2 -lang C#

REM Projetos para testes e domínio do Contencioso
dotnet new classlib -n core.learning.tdd.contencioso -f netcoreapp2.2 -lang C#

REM Projeto para interface com o banco de dados
dotnet new classlib -n core.learning.tdd.application -f netcoreapp2.2 -lang C#

REM Projeto para Testes do domínio
dotnet new nunit -n core.learning.tdd.romanos.test -f netcoreapp2.2 -lang C#
dotnet new nunit -n core.learning.tdd.financeiro.test -f netcoreapp2.2 -lang C#
dotnet new nunit -n core.learning.tdd.contencioso.test -f netcoreapp2.2 -lang C#

REM Projeto de interfaceamento web
dotnet new webapi -n core.learning.tdd.webapi -f netcoreapp2.2 -lang C#

REM Projeto de interface
dotnet new web -n core.learning.tdd.webapp --framework netcoreapp2.2 -lang C#

REM Solução para agrupar os projetos
dotnet new sln

dir

REM Adicionar projetos
dotnet sln add core.learning.tdd.romanos\core.learning.tdd.romanos.csproj
dotnet sln add core.learning.tdd.romanos.test\core.learning.tdd.romanos.test.csproj
dotnet sln add core.learning.tdd.contencioso\core.learning.tdd.contencioso.csproj
dotnet sln add core.learning.tdd.contencioso.test\core.learning.tdd.contencioso.test.csproj
dotnet sln add core.learning.tdd.financeiro\core.learning.tdd.financeiro.csproj
dotnet sln add core.learning.tdd.financeiro.test\core.learning.tdd.financeiro.test.csproj
dotnet sln add core.learning.tdd.financeiro.repository\core.learning.tdd.financeiro.repository.csproj
dotnet sln add core.learning.tdd.application\core.learning.tdd.application.csproj
dotnet sln add core.learning.tdd.webapi\core.learning.tdd.webapi.csproj
dotnet sln add core.learning.tdd.webapp\core.learning.tdd.webapp.csproj

REM Exibir relacionamentos
dotnet sln list

REM Adicionar dependência do domínio ao projeto de teste
dotnet add core.learning.tdd.romanos.test/core.learning.tdd.romanos.test.csproj reference core.learning.tdd.romanos/core.learning.tdd.romanos.csproj

REM Abrir projeto de teste e adicionar pacotes
cd core.learning.tdd.romanos.test

dotnet list reference

dotnet new nunit-test -n ConversorDeNumeroRomanoTest -o .

dotnet add package NUnit.ConsoleRunner
dotnet add package extent

donet restore

dotnet build --configuration Release

dotnet test

PAUSE