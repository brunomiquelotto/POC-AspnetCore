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

Para sincronizar automaticamente os browsers quando houver alterações em css, após a aplicação startada, rodar o comando:

> yarn gulp sync


## TODO
Melhorias identificadas até o momento

- Criar camada de validação de Models
- Criar DTOS para as classes de contexto
- Implementar AutoMapper para realizar o mapeamento DTO -> Classes de contexto e vice-versa
- Melhorar README do github
