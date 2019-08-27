# core.tddLearn
This repository contains Hands on Test Driven Development (TDD) with Mock Objects, Design Principles, Functional tests and Emergent Properties.

Para este projeto usaremos a ferramente de desenvolvimento .Net CLI.
https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet?tabs=netcore21

Verifique a versão instalado do .Net Core, deve ser superior a 2.1.
> dotnet --version

Verificar se o template do nunit já está instalado.
> dotnet new nunit -l

Cria uma pasta para o Projeto/Solução.
> mkdir core.tddLearn
> cd core.tddLearn

Cria um arquivo de Solução que vai conter os projetos.
> dotnet new sln

Criação do projeto de teste com C#.
> dotnet new nunit -n core.tddLearn.test

Adicionando novo projeto a Solução.
> dotnet sln core.tddLearn.sln add core.tddLearn.test/core.tddLearn.test.csproj
> cd core.tddLearn.test

Cria uma classe fixture para o teste no diretório corrente.
> dotnet new nunit-test -n ConversorDeNumeroRomanoTest -o .

Depois de escrever nosso primeiro teste se tentarmos executar ou fazer o build do projeto ele vai falhar, pois não existe a classe de referência.
> dotnet build

Criação de um projeto para as regras do domínio, onde vamos criar a classe que vai ser testada (raiz do diretório).
> dotnet new classlib -n core.tddLearn.domain -f netcoreapp3.0 -lang C#
> dotnet sln core.tddLearn.sln add core.tddLearn.domain/core.tddLearn.domain.csproj

Adicionando uma referência do projeto de regras ao projeto de teste e criando a classe para o build do projeto não falhar. A implementação da classe deve ser o mais simples possível.
> dotnet add core.tddLearn.test/core.tddLearn.test.csproj reference core.tddLearn.domain/core.tddLearn.domain.csproj
> cd core.tddLearn.domain

Tutorial util para criar os templates customizados para teu projeto (qualquer classe que for se repetir muito ou verbosa):
https://docs.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-item-template

Depois de implementar nossa classe, podemos executar o teste que vai falhar.
> cd core.tddLearn.test
> dotnet list reference
> dotnet test

Criação do projeto de teste com linguagem funcional.
> dotnet new nunit -lang F# -n core.tddLearnFSharp.test

Criação de um projeto de interfaceamento web com verbos HTTP (raiz do diretório).
> dotnet new webapi -n core.tddLearn.webapi
> dotnet sln core.tddLearn.sln add core.tddLearn.webapi/core.tddLearn.webapi.csproj
> dotnet sln list

Criando testes automáticos de integração para as APIs com Postman.

Discoverability with Swagger.

Este projeto adota as boas práticas descritas no Livro:
Test Driven Development - Teste e design no mundo real
By Mauricio Aniche