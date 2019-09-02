# core.tddLearn
This repository contains Hands on Test Driven Development (TDD) with Mock Objects, Design Principles, Functional tests and Emergent Properties.

[![Build Status](https://rodrigolessa.visualstudio.com/core.tddLearn/_apis/build/status/rodrigolessa.core.tddLearn?branchName=master)](https://rodrigolessa.visualstudio.com/core.tddLearn/_build?definitionId=2&_a=summary&view=runs)

## Table of Content
 - Prerequisites
 - Creating Dotnet test project with CLI
 - Running tests
 - Generate reports using ReportGenerator (Trxer)
 - Running Code Coverage
 - Organizando os projetos
 - Create a pipeline with Powershell script
 - Create a pipeline on Azure DevOps platform
 - Implementar testes no paradigma funcional
 - Implementar testes de API com Postman
 - Referências

Para este projeto usaremos a ferramente de desenvolvimento .Net CLI.
https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet?tabs=netcore21

### Prerequisites

 - .NET Core SDK
 - .NET Core CLI
 - Visual Studio Code with some plugins:
  - .Net Core Test Explorer
  - Coverage Gutter

Verifique a versão instalado do .Net Core, deve ser superior a 2.0. This will show the list of all available SDKs on your system.
> dotnet --version
> dotnet --info

If necessary, you can changed the current SDK version of the project, you can upgrade, or downgrade the SDK.
> dotnet new globaljson --sdk-version 2.2.108 --force

Verificar se o template do nunit já está instalado.
> dotnet new nunit -l

### Creating Dotnet test project with CLI

Cria uma pasta para o Projeto/Solução.
> mkdir core.tddLearn
> cd core.tddLearn

Primeiro criamos o projeto de teste com C# e uma classe fixture para o teste. Orientação do TDD, desenvolvimento guiado pelos testes ou ciclo red-green-refactor. O primeiro teste falha só depois implementamos a classe com as regras de negócio.
> dotnet new nunit -n core.tddLearn.test
> cd core.tddLearn.test
> dotnet new nunit-test -n ConversorDeNumeroRomanoTest -o .

Vantagens do TDD
 - Ter foco no teste e não na implementação
 - Evitar soluções complexas (YAGNI)
 - O código já nasce testado

Depois de escrever nosso primeiro teste se tentarmos executar ou fazer o build do projeto ele vai falhar, pois não existe a classe de referência.
> dotnet build

Criação de um projeto para as regras do domínio, onde vamos criar a classe que vai ser testada (orientação do TDD, red-green-refactor). Adicionando uma referência do projeto de regras ao projeto de teste e criando a classe para o build do projeto não falhar. A implementação da classe deve ser o mais simples possível.
> cd ..
> dotnet new classlib -n core.tddLearn.domain -f netcoreapp3.0 -lang C#
> dotnet add core.tddLearn.test/core.tddLearn.test.csproj reference core.tddLearn.domain/core.tddLearn.domain.csproj

### Running tests

Depois de implementar nossa classe, podemos executar o teste que vai falhar.
> cd core.tddLearn.test
> dotnet list reference
> dotnet test

### Generate reports using ReportGenerator (Trxer)

### Running Code Coverage

### Organizando os projetos

Cria um arquivo de Solução que vai conter os projetos.
> dotnet new sln
> dotnet sln core.tddLearn.sln add core.tddLearn.domain/core.tddLearn.domain.csproj
> dotnet sln core.tddLearn.sln add core.tddLearn.test/core.tddLearn.test.csproj
> dotnet sln core.tddLearn.sln add core.tddLearn.webapi/core.tddLearn.webapi.csproj
> dotnet sln list

### Create a pipeline with Powershell script

### Create a pipeline on Azure DevOps platform

### Implementar testes no paradigma funcional

Criação do projeto de teste com linguagem funcional.
> dotnet new nunit -lang F# -n core.tddLearnFSharp.test

### Implementar testes de API com Postman

Criando testes automáticos de integração para as APIs com Postman.
Criação de um projeto de interfaceamento web com verbos HTTP (raiz do diretório).
> dotnet new webapi -n core.tddLearn.webapi

Discoverability with Swagger.

### Referências

Este projeto adota as boas práticas descritas no Livro:
Test Driven Development - Teste e design no mundo real
By Mauricio Aniche

Tutorial util para criar os templates customizados para teu projeto (qualquer classe que for se repetir muito ou verbosa):
https://docs.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-item-template