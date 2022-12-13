USE [Taxonomias]
GO

/****** Object:  UserDefinedFunction [dbo].[fnc_get_reino]    Script Date: 19/4/2022 13:43:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[fnc_get_reino] (@nombreComun VARCHAR(30))
RETURNS VARCHAR(30)
AS
BEGIN
	RETURN (
			SELECT idReino
			FROM reino
			INNER JOIN phylum ON reino.idReino = phylum.reino_idReino
			INNER JOIN clase ON phylum.idPhylum = clase.Phylum_idPhylum
			INNER JOIN orden ON clase.idClase = orden.Clase_idClase
			INNER JOIN familia ON orden.idOrden = familia.Orden_idOrden
			INNER JOIN genero ON familia.idFamilia = genero.Familia_idFamilia
			INNER JOIN especie ON genero.idGenero = especie.Genero_idGenero
			WHERE especie.nombre_comun = @nombreComun
			)
END
GO


