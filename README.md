﻿# core.learning.tdd
This repository contains Hands on Test Driven Development (TDD) with Mock Objects, Design Principles, Functional tests and Emergent Properties.

[![Build Status](https://rodrigolessa.visualstudio.com/core.learning.tdd/_apis/build/status/rodrigolessa.core.learning.tdd?branchName=master)](https://rodrigolessa.visualstudio.com/core.learning.tdd/_build?definitionId=2&_a=summary&view=runs) [![Build Status](https://travis-ci.org/rodrigolessa/core.learning.tdd.svg?branch=master)](https://travis-ci.org/rodrigolessa/core.learning.tdd)

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
 - Creating especification test wirh Gauge
 - Design Patterns and Development Strategies
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
```shell
dotnet --version
dotnet --info
```

If necessary, you can changed the current SDK version of the project, you can upgrade, or downgrade the SDK.
```shell
dotnet new globaljson --sdk-version 2.2.108 --force
```

Verificar se o template do nunit já está instalado.
```shell
dotnet new nunit -l
```

### Creating Dotnet test project with CLI

Cria uma pasta para o Projeto/Solução.
```shell
mkdir core-learning-tdd
cd core-learning-tdd
```

Primeiro criamos o projeto de teste com C# e uma classe fixture para o teste. Orientação do TDD, desenvolvimento guiado pelos testes ou ciclo red-green-refactor. O primeiro teste falha só depois implementamos a classe com as regras de negócio.
```shell
dotnet new nunit -n core.learning.tdd.test
cd core.learning.tdd.test
dotnet new nunit-test -n ConversorDeNumeroRomanoTest -o .
```

Vantagens do TDD
 - Ter foco no teste e não na implementação
 - Evitar soluções complexas (YAGNI)
 - O código já nasce testado

Depois de escrever nosso primeiro teste se tentarmos executar ou fazer o build do projeto ele vai falhar, pois não existe a classe de referência.
```shell
dotnet build --configuration Release
```

Criação de um projeto para as regras do domínio, onde vamos criar a classe que vai ser testada (orientação do TDD, red-green-refactor). Adicionando uma referência do projeto de regras ao projeto de teste e criando a classe para o build do projeto não falhar. A implementação da classe deve ser o mais simples possível.
```shell
cd ..
dotnet new classlib -n core.learning.tdd.domain -f netcoreapp2.2 -lang C#
dotnet add core.learning.tdd.test/core.learning.tdd.test.csproj reference core.learning.tdd.domain/core.learning.tdd.domain.csproj
```

dotnet add core.learning.tdd.test.csproj reference core.learning.tdd.domain/core.learning.tdd.domain.csproj

### Running tests

#### User case: The Roman Numbers Convert

#### Symbols

| 1 | 5 | 10 | 50 | 100 | 500 | 1000 |
|:-:|:-:|:--:|:--:|:---:|:---:|:----:|
| I | V | X  | L  | C   | D   | M    |

#### Combinations

| 2  | 3   | 4  | 6  | 7   | 8    | 9  | 40 | 90 | 400 | 900 |
|:--:|:---:|:--:|:--:|:---:|:----:|:--:|:--:|:--:|:---:|:---:|
| II | III | IV | VI | VII | VIII | IX | XL | XC | CD  | CM  |

Depois de implementar nossa classe, podemos executar o teste que vai falhar.
```shell
cd core.learning.tdd.test
dotnet list reference
dotnet test
```

### Generate reports using ReportGenerator (Trxer)

```shell
cd core.learning.tdd.test
dotnet add package NUnit.ConsoleRunner
nunit3-console bin\Debug\netcoreapp2.2\core.learning.tdd.test.dll
```

### Generate reports using Extent

Created a report file from NUnit results.xml.

```shell
cd core.learning.tdd.test
dotnet add package extent
dotnet test
```

### Running Code Coverage

### Organizando os projetos

Cria um arquivo de Solução que vai conter os projetos.
```shell
dotnet new sln
dotnet sln core.learning.tdd.sln add core.learning.tdd.domain/core.learning.tdd.domain.csproj
dotnet sln core.learning.tdd.sln add core.learning.tdd.test/core.learning.tdd.test.csproj

dotnet sln list
```

### Create a pipeline with Powershell script

### Create a pipeline on Azure DevOps platform

### Implementar testes no paradigma funcional

Criação do projeto de teste com linguagem funcional.
```shell
dotnet new nunit -lang F# -n core.learning.tddFSharp.test
```

### Implementar testes de API com Postman

Criando testes automáticos de integração para as APIs com Postman.
Criação de um projeto de interfaceamento web com verbos HTTP (raiz do diretório).
```shell
dotnet new webapi -n core.learning.tdd.webapi
dotnet sln add core.learning.tdd.webapi/core.learning.tdd.webapi.csproj
```

Discoverability with Swagger.

### Utilizando este repositório

Ao clonar o repositório é necessário recarregar as dependências dos projetos
```shel
dotnet restore
dotnet build
```

### Creating acceptance testing project wirh Gauge

Reference - https://gauge.org/

Installation - Run from PowerShell command with admin rights.
```shel
choco install gauge # installation
```

```shel
mkdir core.learning.gauge
cd    core.learning.gauge

gauge init dotnet

gauge run specs/
```


### Design Patterns and Development Strategies

PageObjects: 
A simple abstraction of the UI of your web app
Best reference to https://martinfowler.com/bliki/PageObject.html

AcceptanceTests: 
Use coarse-grained UI tests to help structure development work.

RegressionTests: 
Collect the actions of multiple AcceptanceTests into one place for ease of maintenance.

DomainDrivenDesign: 
Express your tests in the language of the end-user of the app.

### Referências

Este projeto adota as boas práticas descritas no Livro:
Test Driven Development - Teste e design no mundo real
By Mauricio Aniche

Tutorial util para criar os templates customizados para teu projeto (qualquer classe que for se repetir muito ou for muito verbosa):
https://docs.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-item-template

Visual Studio Code working with projects settings using .code-workspace
https://stackoverflow.com/questions/44629890/what-is-a-workspace-in-vs-code

Verificar templates disponíveis para criação de projetos e classes
```shel
dotnet new --list
```