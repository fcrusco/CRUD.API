# CRUD.API - API RESTful com Autenticação JWT
<br><br>
Este projeto implementa uma API RESTful em .NET 6 utilizando ASP.NET Core, que expõe operações básicas de CRUD para a entidade Usuario, com autenticação via JWT e acesso a dados via procedures no SQL Server.
<br><br>
## -Tecnologias utilizadas<br>
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
## -Estrutura da solução<br>
A solução é composta por 6 projetos:<br>
CRUD.API	Projeto Web API com endpoints REST<br>
CRUD.Interface	Contratos (interfaces) para os serviços<br>
CRUD.Model	Modelos de domínio (ex: Usuario.cs)<br>
CRUD.Service	Lógica de negócios e acesso a banco via ADO.NET<br>
CRUD.Client	Cliente HTTP para consumo da API<br>
CRUD.Test	Projeto de testes unitários com NUnit<br>
<br>
## -Autenticação<br>
A API utiliza autenticação via JWT<br>
Use o token retornado como Bearer Token no Swagger para acessar os demais endpoints protegidos.<br>
<br>
## -Endpoints disponíveis<br>
GET	/api/usuario	Listar todos os usuários<br>
GET	/api/usuario/{id}	Buscar por ID<br>
POST	/api/usuario	Inserir novo usuário<br>
PUT	/api/usuario/{id}	Atualizar usuário<br>
DELETE	/api/usuario/{id}	Excluir usuário<br>
<br>
## -Testes<br>
Os testes unitários foram implementados com NUnit no projeto CRUD.Test.<br>
<br>
## -Pacotes NuGet<br>
O projeto pode ser empacotado como dois pacotes NuGet:<br>
CRUD.API.Client – Cliente HTTP para integração<br>
MyNugets – Pacote com componentes reutilizáveis<br>
<br>
## -Como executar<br>
Configure o SQL Server e execute o script com as procedures<br>
Ajuste a ConnectionString no appsettings.json<br>

Execute a aplicação via Visual Studio 2022

Acesse o Swagger em: https://localhost:{porta}/swagger
<br>
<br>
<br>
# CRUD.API<br>RESTful API with JWT Authentication
<br><br>
This project implements a RESTful API in .NET 6 using ASP.NET Core, which exposes basic CRUD operations for the `Usuario` entity, with JWT authentication and data access via stored procedures in SQL Server.
<br><br>
-Technologies Used<br>
ASP.NET Core 6<br>
Web API<br>
SQL Server<br>
Stored Procedures<br>
JWT (JSON Web Token)<br>
Swagger (OpenAPI)<br>
Dependency Injection (DI)<br>
NUnit (for unit tests)<br>
Visual Studio 2022<br>
<br>
-Solution Structure<br>
The solution is composed of 6 projects:<br>
CRUD.API – Web API project with REST endpoints<br>
CRUD.Interface – Contracts (interfaces) for services<br>
CRUD.Model – Domain models (e.g., Usuario.cs)<br>
CRUD.Service – Business logic and database access via ADO.NET<br>
CRUD.Client – HTTP client for consuming the API<br>
CRUD.Test – Unit test project using NUnit<br>
<br>
-Authentication<br>
The API uses JWT authentication<br>
Use the returned token as a Bearer Token in Swagger to access the protected endpoints.<br>
<br>
-Available Endpoints<br>
GET	/api/usuario	List all users<br>
GET	/api/usuario/{id}	Get user by ID<br>
POST	/api/usuario	Insert new user<br>
PUT	/api/usuario/{id}	Update user<br>
DELETE	/api/usuario/{id}	Delete user<br>
<br>
-Tests<br>
Unit tests were implemented with NUnit in the `CRUD.Test` project.<br>
<br>
-NuGet Packages<br>
The project can be packaged as two NuGet packages:<br>
CRUD.API.Client – HTTP client for integration<br>
MyNugets – Package with reusable components<br>
<br>
-How to Run<br>
Configure SQL Server and run the script with the stored procedures<br>
Adjust the `ConnectionString` in `appsettings.json`<br>

Run the application via Visual Studio 2022

Access Swagger at: https://localhost:{port}/swagger
<br>
<br>
<br>
# CRUD.API<br>API RESTful con Autenticación JWT
<br><br>
Este proyecto implementa una API RESTful en .NET 6 utilizando ASP.NET Core, que expone operaciones básicas de CRUD para la entidad `Usuario`, con autenticación JWT y acceso a datos mediante procedimientos almacenados en SQL Server.
<br><br>
-Tecnologías utilizadas<br>
ASP.NET Core 6<br>
Web API<br>
SQL Server<br>
Procedimientos almacenados<br>
JWT (JSON Web Token)<br>
Swagger (OpenAPI)<br>
Inyección de Dependencias (DI)<br>
NUnit (para pruebas unitarias)<br>
Visual Studio 2022<br>
<br>
-Estructura de la solución<br>
La solución está compuesta por 6 proyectos:<br>
CRUD.API – Proyecto Web API con endpoints REST<br>
CRUD.Interface – Contratos (interfaces) para los servicios<br>
CRUD.Model – Modelos de dominio (por ejemplo, Usuario.cs)<br>
CRUD.Service – Lógica de negocio y acceso a base de datos mediante ADO.NET<br>
CRUD.Client – Cliente HTTP para consumir la API<br>
CRUD.Test – Proyecto de pruebas unitarias con NUnit<br>
<br>
-Autenticación<br>
La API utiliza autenticación JWT<br>
Usa el token retornado como Bearer Token en Swagger para acceder a los endpoints protegidos.<br>
<br>
-Endpoints disponibles<br>
GET	/api/usuario	Listar todos los usuarios<br>
GET	/api/usuario/{id}	Buscar por ID<br>
POST	/api/usuario	Insertar nuevo usuario<br>
PUT	/api/usuario/{id}	Actualizar usuario<br>
DELETE	/api/usuario/{id}	Eliminar usuario<br>
<br>
-Pruebas<br>
Las pruebas unitarias fueron implementadas con NUnit en el proyecto `CRUD.Test`.<br>
<br>
-Paquetes NuGet<br>
El proyecto puede ser empaquetado como dos paquetes NuGet:<br>
CRUD.API.Client – Cliente HTTP para integración<br>
MyNugets – Paquete con componentes reutilizables<br>
<br>
-Cómo ejecutar<br>
Configura el SQL Server y ejecuta el script con los procedimientos almacenados<br>
Ajusta la `ConnectionString` en `appsettings.json`<br>

Ejecuta la aplicación usando Visual Studio 2022

Accede al Swagger en: https://localhost:{puerto}/swagger


