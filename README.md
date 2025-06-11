# CRUD.API - API RESTful com Autenticação JWT
<br><br>
Este projeto implementa uma API RESTful em .NET 6 utilizando ASP.NET Core, que expõe operações básicas de CRUD para a entidade Usuario, com autenticação via JWT e acesso a dados via procedures no SQL Server.
<br><br>
-Tecnologias utilizadas<br>
ASP.NET Core 6<br>
Web API<br>
SQL Server<br>
Procedures armazenadas<br>
JWT (JSON Web Token)<br>
Swagger (OpenAPI)<br>
Injeção de Dependência (DI)<br>
NUnit (para testes unitários)<br>
Visual Studio 2022<br>
<br>
-Estrutura da solução<br>
A solução é composta por 6 projetos:<br>
CRUD.API	Projeto Web API com endpoints REST<br>
CRUD.Interface	Contratos (interfaces) para os serviços<br>
CRUD.Model	Modelos de domínio (ex: Usuario.cs)<br>
CRUD.Service	Lógica de negócios e acesso a banco via ADO.NET<br>
CRUD.Client	Cliente HTTP para consumo da API<br>
CRUD.Test	Projeto de testes unitários com NUnit<br>
<br>
-Autenticação<br>
A API utiliza autenticação via JWT<br>
Use o token retornado como Bearer Token no Swagger para acessar os demais endpoints protegidos.<br>
<br>
-Endpoints disponíveis<br>
GET	/api/usuario	Listar todos os usuários<br>
GET	/api/usuario/{id}	Buscar por ID<br>
POST	/api/usuario	Inserir novo usuário<br>
PUT	/api/usuario/{id}	Atualizar usuário<br>
DELETE	/api/usuario/{id}	Excluir usuário<br>
<br>
-Testes<br>
Os testes unitários foram implementados com NUnit no projeto CRUD.Test.<br>
<br>
-Pacotes NuGet<br>
O projeto pode ser empacotado como dois pacotes NuGet:<br>
CRUD.API.Client – Cliente HTTP para integração<br>
MyNugets – Pacote com componentes reutilizáveis<br>
<br>
-Como executar<br>
Configure o SQL Server e execute o script com as procedures<br>
Ajuste a ConnectionString no appsettings.json<br>

Execute a aplicação via Visual Studio 2022

Acesse o Swagger em: https://localhost:{porta}/swagger


