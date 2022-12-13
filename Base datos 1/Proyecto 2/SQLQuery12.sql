SELECT * FROM reino
INNER JOIN phylum ON reino.idReino=phylum.reino_idReino
INNER JOIN clase ON phylum.idPhylum=clase.Phylum_idPhylum
INNER JOIN orden ON clase.idClase=orden.Clase_idClase
INNER JOIN familia ON orden.idOrden=familia.Orden_idOrden
INNER JOIN genero ON familia.idFamilia=genero.Familia_idFamilia
INNER JOIN especie ON genero.idGenero=especie.Genero_idGenero
WHERE especie.nombre_comun='Vaca'