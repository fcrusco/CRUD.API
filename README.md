# CRUD.API - API RESTful com Autenticação JWT

Este projeto implementa uma API RESTful em .NET 6 utilizando ASP.NET Core, que expõe operações básicas de CRUD para a entidade Usuario, com autenticação via JWT e acesso a dados via procedures no SQL Server.

-Tecnologias utilizadas

ASP.NET Core 6

Web API

SQL Server

Procedures armazenadas

JWT (JSON Web Token)

Swagger (OpenAPI)

Injeção de Dependência (DI)

NUnit (para testes unitários)

Visual Studio 2022




-Estrutura da solução

A solução é composta por 6 projetos:

CRUD.API	Projeto Web API com endpoints REST

CRUD.Interface	Contratos (interfaces) para os serviços

CRUD.Model	Modelos de domínio (ex: Usuario.cs)

CRUD.Service	Lógica de negócios e acesso a banco via ADO.NET

CRUD.Client	Cliente HTTP para consumo da API

CRUD.Test	Projeto de testes unitários com NUnit




-Autenticação

A API utiliza autenticação via JWT

Use o token retornado como Bearer Token no Swagger para acessar os demais endpoints protegidos.




-Endpoints disponíveis

GET	/api/usuario	Listar todos os usuários

GET	/api/usuario/{id}	Buscar por ID

POST	/api/usuario	Inserir novo usuário

PUT	/api/usuario/{id}	Atualizar usuário

DELETE	/api/usuario/{id}	Excluir usuário




-Testes

Os testes unitários foram implementados com NUnit no projeto CRUD.Test.




-Pacotes NuGet

O projeto pode ser empacotado como dois pacotes NuGet:

CRUD.API.Client – Cliente HTTP para integração

MyNugets – Pacote com componentes reutilizáveis




-Como executar

Configure o SQL Server e execute o script com as procedures

Ajuste a ConnectionString no appsettings.json

Execute a aplicação via Visual Studio 2022

Acesse o Swagger em: https://localhost:{porta}/swagger


