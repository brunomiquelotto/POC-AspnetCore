# POC-AspnetCore

## Pré requisitos:
.NETCore SDK

## Para executar o projeto:

1 - Criar banco de dados sqlserver, e modificar a connection string em Projeto/appsettings.json

2 - Rodar as migrations para criação das tabelas com os comandos:

> cd Db/

> dotnetcore ef database update --startup-project=../Projeto/Projeto.csproj

> cd ..

> cd Projeto/

> dotnet watch run
