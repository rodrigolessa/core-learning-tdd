﻿# core.tddLearn
This repository contains Hands on Test Driven Development (TDD) with Mock Objects, Design Principles, Functional tests and Emergent Properties.

[![Build Status](https://rodrigolessa.visualstudio.com/core.tddLearn/_apis/build/status/rodrigolessa.core.tddLearn?branchName=master)](https://rodrigolessa.visualstudio.com/core.tddLearn/_build?definitionId=2&_a=summary&view=runs) [![Build Status](https://travis-ci.org/rodrigolessa/core.tddLearn.svg?branch=master)](https://travis-ci.org/rodrigolessa/core.tddLearn)

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
mkdir core.tddLearn
cd core.tddLearn
```

Primeiro criamos o projeto de teste com C# e uma classe fixture para o teste. Orientação do TDD, desenvolvimento guiado pelos testes ou ciclo red-green-refactor. O primeiro teste falha só depois implementamos a classe com as regras de negócio.
```shell
dotnet new nunit -n core.tddLearn.test
cd core.tddLearn.test
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
dotnet new classlib -n core.tddLearn.domain -f netcoreapp3.0 -lang C#
dotnet add core.tddLearn.test/core.tddLearn.test.csproj reference core.tddLearn.domain/core.tddLearn.domain.csproj
```

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
cd core.tddLearn.test
dotnet list reference
dotnet test
```

### Generate reports using ReportGenerator (Trxer)

### Generate reports using Extent

```shell
cd core.tddLearn.test
dotnet add package extent
dotnet test
```

### Running Code Coverage

### Organizando os projetos

Cria um arquivo de Solução que vai conter os projetos.
```shell
dotnet new sln
dotnet sln core.tddLearn.sln add core.tddLearn.domain/core.tddLearn.domain.csproj
dotnet sln core.tddLearn.sln add core.tddLearn.test/core.tddLearn.test.csproj
dotnet sln core.tddLearn.sln add core.tddLearn.webapi/core.tddLearn.webapi.csproj
dotnet sln list
```

### Create a pipeline with Powershell script

### Create a pipeline on Azure DevOps platform

### Implementar testes no paradigma funcional

Criação do projeto de teste com linguagem funcional.
```shell
dotnet new nunit -lang F# -n core.tddLearnFSharp.test
```

### Implementar testes de API com Postman

Criando testes automáticos de integração para as APIs com Postman.
Criação de um projeto de interfaceamento web com verbos HTTP (raiz do diretório).
```shell
dotnet new webapi -n core.tddLearn.webapi
```

Discoverability with Swagger.

### Referências

Este projeto adota as boas práticas descritas no Livro:
Test Driven Development - Teste e design no mundo real
By Mauricio Aniche

Tutorial util para criar os templates customizados para teu projeto (qualquer classe que for se repetir muito ou verbosa):
https://docs.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-item-template