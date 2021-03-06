ALTER PROCEDURE [dbo].[CiudadSave]
    @ID         int OUTPUT,
    @Nombre     varchar(50),
    @IDEstado   int
AS
IF EXISTS (SELECT * FROM Ciudad WHERE ID = @ID)
    UPDATE Ciudad
       SET  Nombre = @Nombre,
            IDEstado = @IDEstado
     WHERE ID = @ID
ELSE
    BEGIN
        INSERT INTO Ciudad (Nombre, IDEstado)
        VALUES (@Nombre, @IDEstado)

        SET @ID = SCOPE_IDENTITY()
    END
GO

declare @id int
exec CiudadSave @id output, 'Zuazua', 1

select @id
select * from Ciudad

exec CiudadSave @ID = @id OUTPUT, @Nombre = 'Zuazua', @IDEstado = 1
