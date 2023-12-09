USE [PRODUCTOS]
GO
/****** Object:  StoredProcedure [dbo].[LISTAR_PRODUCTOS]    Script Date: 08/12/2023 10:59:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[LISTAR_PRODUCTOS]
@cTexto varchar 
AS
	SELECT a.ID_Categoria, a.Nombre, a.Precio, a.Stock, c.Nombre
	FROM Productos a
	inner join Categorias c on a.ID_Categoria = c.ID_Categoria;
