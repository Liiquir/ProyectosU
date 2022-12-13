USE [Taxonomias]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_inserta_registro]
-- Params
(
@nombreComun varchar(30), @especie  varchar(30),
@genero  varchar(30), @familia  varchar(30),@orden  varchar(30), @clase  varchar(30),
@phylum  varchar(30), @reino varchar(30))
AS

BEGIN
	
	SET NOCOUNT ON;

    -- Como todos los campos de la mayoria de tablas con primary keys, la base de datos evita los duplicados

	INSERT INTO [dbo].[reino] ([idReino]) VALUES(@reino)
	INSERT INTO [dbo].phylum([idPhylum],[reino_idReino]) VALUES(@phylum,@reino)
	INSERT INTO [dbo].clase([idClase],[Phylum_idPhylum]) VALUES(@clase,@phylum)
	INSERT INTO [dbo].orden([idOrden],[Clase_idClase]) VALUES(@orden,@clase)
	INSERT INTO [dbo].familia([idFamilia],[Orden_idOrden]) VALUES(@familia,@orden)
	INSERT INTO [dbo].genero([idGenero],[Familia_idFamilia]) VALUES(@genero,@familia)
	INSERT INTO [dbo].especie([idEspecie],[Genero_idGenero],[nombre_cientifico],[nombre_comun]) VALUES(@especie,@genero,@especie+' '+@genero,@nombreComun)
END
GO


