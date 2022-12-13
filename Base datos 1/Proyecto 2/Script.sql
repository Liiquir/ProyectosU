USE [Taxonomias]
GO
/** 1. Genere el script para cargar los siguientes datos, en el esquema de base de datos:**/
INSERT [dbo].[reino] ([idReino]) VALUES (N'Animal')
GO
INSERT [dbo].[reino] ([idReino]) VALUES (N'Vegetal')
GO
INSERT [dbo].[phylum] ([idPhylum], [reino_idReino]) VALUES (N'Chordata', N'Animal')
GO
INSERT [dbo].[phylum] ([idPhylum], [reino_idReino]) VALUES (N'Tracheophyta', N'Vegetal')
GO
INSERT [dbo].[clase] ([idClase], [Phylum_idPhylum]) VALUES (N'Angiosperma', N'Tracheophyta')
GO
INSERT [dbo].[clase] ([idClase], [Phylum_idPhylum]) VALUES (N'Mammalia', N'Chordata')
GO
INSERT [dbo].[orden] ([idOrden], [Clase_idClase]) VALUES (N'Artiodactyla', N'Mammalia')
GO
INSERT [dbo].[orden] ([idOrden], [Clase_idClase]) VALUES (N'Carnívora', N'Mammalia')
GO
INSERT [dbo].[orden] ([idOrden], [Clase_idClase]) VALUES (N'Cetacea', N'Mammalia')
GO
INSERT [dbo].[orden] ([idOrden], [Clase_idClase]) VALUES (N'Glumifloral', N'Angiosperma')
GO
INSERT [dbo].[orden] ([idOrden], [Clase_idClase]) VALUES (N'Primate', N'Mammalia')
GO
INSERT [dbo].[familia] ([idFamilia], [Orden_idOrden]) VALUES (N'Balaenopteridae', N'Cetacea')
GO
INSERT [dbo].[familia] ([idFamilia], [Orden_idOrden]) VALUES (N'Bovidae', N'Artiodactyla')
GO
INSERT [dbo].[familia] ([idFamilia], [Orden_idOrden]) VALUES (N'Canidae', N'Carnívora')
GO
INSERT [dbo].[familia] ([idFamilia], [Orden_idOrden]) VALUES (N'Felidae', N'Carnívora')
GO
INSERT [dbo].[familia] ([idFamilia], [Orden_idOrden]) VALUES (N'Gramínea', N'Glumifloral')
GO
INSERT [dbo].[familia] ([idFamilia], [Orden_idOrden]) VALUES (N'Hominidae', N'Primate')
GO
INSERT [dbo].[genero] ([idGenero], [Familia_idFamilia]) VALUES (N'Bos', N'Bovidae')
GO
INSERT [dbo].[genero] ([idGenero], [Familia_idFamilia]) VALUES (N'Canis', N'Canidae')
GO
INSERT [dbo].[genero] ([idGenero], [Familia_idFamilia]) VALUES (N'Felis', N'Felidae')
GO
INSERT [dbo].[genero] ([idGenero], [Familia_idFamilia]) VALUES (N'Homo', N'Hominidae')
GO
INSERT [dbo].[genero] ([idGenero], [Familia_idFamilia]) VALUES (N'Megaptera', N'Balaenopteridae')
GO
INSERT [dbo].[genero] ([idGenero], [Familia_idFamilia]) VALUES (N'Zea', N'Gramínea')
GO
INSERT [dbo].[especie] ([idEspecie], [Genero_idGenero], [nombre_cientifico], [nombre_comun]) VALUES (N'Familiaris', N'Canis', N'Canis Familiaris', N'Perro')
GO
INSERT [dbo].[especie] ([idEspecie], [Genero_idGenero], [nombre_cientifico], [nombre_comun]) VALUES (N'Maíz', N'Zea', N'Zea Maiz', N'Maíz')
GO
INSERT [dbo].[especie] ([idEspecie], [Genero_idGenero], [nombre_cientifico], [nombre_comun]) VALUES (N'Novaeangliae', N'Megaptera', N'Megaptera Novaeangliae', N'Ballena
Jorobada')
GO
INSERT [dbo].[especie] ([idEspecie], [Genero_idGenero], [nombre_cientifico], [nombre_comun]) VALUES (N'Sapiens', N'Homo', N'Homo
Sapiens', N'Hombre')
GO
INSERT [dbo].[especie] ([idEspecie], [Genero_idGenero], [nombre_cientifico], [nombre_comun]) VALUES (N'Silvestris', N'Felis', N'Felis
 Silvestris', N'Gato')
GO
INSERT [dbo].[especie] ([idEspecie], [Genero_idGenero], [nombre_cientifico], [nombre_comun]) VALUES (N'Taurus', N'Bos', N'Bos Taurus', N'Vaca')
GO

SELECT idReino,	idPhylum idClase,idOrden,idFamilia,idGenero,idEspecie,nombre_cientifico,nombre_comun FROM reino
INNER JOIN phylum ON reino.idReino=phylum.reino_idReino
INNER JOIN clase ON phylum.idPhylum=clase.Phylum_idPhylum
INNER JOIN orden ON clase.idClase=orden.Clase_idClase
INNER JOIN familia ON orden.idOrden=familia.Orden_idOrden
INNER JOIN genero ON familia.idFamilia=genero.Familia_idFamilia
INNER JOIN especie ON genero.idGenero=especie.Genero_idGenero

/** 
2. Genere un comando sql, que permita obtener la taxonomía completa de la vaca: 
**/

SELECT idReino,	idPhylum idClase,idOrden,		idFamilia,		idGenero	,	idEspecie,	nombre_cientifico,	nombre_comun FROM reino
INNER JOIN phylum ON reino.idReino=phylum.reino_idReino
INNER JOIN clase ON phylum.idPhylum=clase.Phylum_idPhylum
INNER JOIN orden ON clase.idClase=orden.Clase_idClase
INNER JOIN familia ON orden.idOrden=familia.Orden_idOrden
INNER JOIN genero ON familia.idFamilia=genero.Familia_idFamilia
INNER JOIN especie ON genero.idGenero=especie.Genero_idGenero
WHERE especie.nombre_comun='Vaca'

/** 
3. Genere un comando sql, que permite obtener la taxonomía completa de todos los seres vivos del reino vegetal:
**/

SELECT idReino,	idPhylum idClase,idOrden,idFamilia,idGenero,idEspecie,nombre_cientifico,nombre_comun
FROM reino
INNER JOIN phylum ON reino.idReino=phylum.reino_idReino
INNER JOIN clase ON phylum.idPhylum=clase.Phylum_idPhylum
INNER JOIN orden ON clase.idClase=orden.Clase_idClase
INNER JOIN familia ON orden.idOrden=familia.Orden_idOrden
INNER JOIN genero ON familia.idFamilia=genero.Familia_idFamilia
INNER JOIN especie ON genero.idGenero=especie.Genero_idGenero
WHERE reino.idReino='Vegetal'

/** 
4. Genere los scripts necesarios en sql, para borrar de la base de datos toda la
taxonomía relacionada a la “Vaca”.
**/

DELETE especie FROM reino
INNER JOIN phylum ON reino.idReino=phylum.reino_idReino
INNER JOIN clase ON phylum.idPhylum=clase.Phylum_idPhylum
INNER JOIN orden ON clase.idClase=orden.Clase_idClase
INNER JOIN familia ON orden.idOrden=familia.Orden_idOrden
INNER JOIN genero ON familia.idFamilia=genero.Familia_idFamilia
INNER JOIN especie ON genero.idGenero=especie.Genero_idGenero
WHERE especie.nombre_comun='Vaca'

/** 
5. Genere un script en sql, que cambie el nombre “Hombre” por “Hombre/Mujer” en
los nombres comunes.
**/

UPDATE especie SET nombre_comun='Hombre/Mujer' WHERE nombre_comun='Hombre'