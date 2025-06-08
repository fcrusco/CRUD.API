CREATE LOGIN sistema_app WITH PASSWORD = 'SenhaForte@123';


CREATE DATABASE AppDev;
GO


USE AppDev;
GO
CREATE USER sistema_app FOR LOGIN sistema_app;
GO


-- Permissões
GRANT EXECUTE ON SCHEMA::dbo TO sistema_app;


--Criar tabela
CREATE TABLE dbo.TB_USUARIO (
    UsuarioId INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
SobreNome NVARCHAR(100) NOT NULL 
);
GO

SELECT * FROM dbo.TB_USUARIO;

--procs
CREATE OR ALTER PROCEDURE dbo.sp_insert_usuario
    @Nome NVARCHAR(100),
    @SobreNome NVARCHAR(100)
WITH EXECUTE AS OWNER
AS
BEGIN
    BEGIN TRY
        IF @Nome IS NULL OR @SobreNome IS NULL
        BEGIN
            RAISERROR('Nome e SobreNome são obrigatórios.', 16, 1);
            RETURN;
        END

        INSERT INTO dbo.TB_USUARIO (Nome, SobreNome)
        VALUES (@Nome, @SobreNome);

        DECLARE @NovoId INT = SCOPE_IDENTITY();

        SELECT @NovoId AS UsuarioId;
    END TRY
    BEGIN CATCH
        SELECT 
            ERROR_MESSAGE() AS Erro,
            ERROR_NUMBER() AS CodigoErro;
    END CATCH
END;
GO


CREATE OR ALTER PROCEDURE dbo.sp_update_usuario
    @UsuarioId INT,
    @Nome NVARCHAR(100),
    @SobreNome NVARCHAR(100)
WITH EXECUTE AS OWNER
AS
BEGIN
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM dbo.TB_USUARIO WHERE UsuarioId = @UsuarioId)
        BEGIN
            RAISERROR('Usuário não encontrado.', 16, 1);
            RETURN;
        END

        UPDATE dbo.TB_USUARIO
        SET Nome = @Nome,
            SobreNome = @SobreNome
        WHERE UsuarioId = @UsuarioId;

        SELECT 'Usuário atualizado com sucesso.' AS Mensagem;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Erro, ERROR_NUMBER() AS CodigoErro;
    END CATCH
END;
GO



CREATE OR ALTER PROCEDURE dbo.sp_delete_usuario
    @UsuarioId INT
WITH EXECUTE AS OWNER
AS
BEGIN
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM dbo.TB_USUARIO WHERE UsuarioId = @UsuarioId)
        BEGIN
            RAISERROR('Usuário não encontrado.', 16, 1);
            RETURN;
        END

        DELETE FROM dbo.TB_USUARIO WHERE UsuarioId = @UsuarioId;

        SELECT 'Usuário deletado com sucesso.' AS Mensagem;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Erro, ERROR_NUMBER() AS CodigoErro;
    END CATCH
END;
GO



CREATE OR ALTER PROCEDURE dbo.sp_get_usuario_by_id
    @UsuarioId INT
WITH EXECUTE AS OWNER
AS
BEGIN
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM dbo.TB_USUARIO WHERE UsuarioId = @UsuarioId)
        BEGIN
            RAISERROR('Usuário não encontrado.', 16, 1);
            RETURN;
        END

        SELECT UsuarioId, Nome, SobreNome
        FROM dbo.TB_USUARIO
        WHERE UsuarioId = @UsuarioId;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Erro, ERROR_NUMBER() AS CodigoErro;
    END CATCH
END;
GO



CREATE OR ALTER PROCEDURE dbo.sp_listar_usuarios
WITH EXECUTE AS OWNER
AS
BEGIN
    BEGIN TRY
        SELECT UsuarioId, Nome, SobreNome
        FROM dbo.TB_USUARIO
        ORDER BY Nome, SobreNome;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Erro, ERROR_NUMBER() AS CodigoErro;
    END CATCH
END;
GO




EXEC dbo.sp_insert_usuario @Nome = 'Joao', @SobreNome = 'Almeida';
EXEC dbo.sp_update_usuario @UsuarioId = 6, @Nome = 'Joao', @SobreNome = 'Vergueiro';
EXEC dbo.sp_get_usuario_by_id @UsuarioId = 6;
EXEC dbo.sp_listar_usuarios;
EXEC dbo.sp_delete_usuario @UsuarioId = 6;
