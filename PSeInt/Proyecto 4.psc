Algoritmo ConcursoBaile
	Definir ronda Como Entero;
	// Matriz de calificaciones, jueces, participantes y vector de calificaciones de parejas
	Definir tablaCalificaciones,calificacionesParejas,Total,fila,col,pareja,menor,eliminado Como Entero;
	Dimension tablaCalificaciones(11,6);
	Dimension calificacionesParejas(10), total(10);
	// Inicializa el vector total en 0 para facilitar la logica del programa
	Para col<-0 Hasta 9 Con Paso 1 Hacer
		total(col) = 0;
	FinPara
	// Fila Jueces y Columna parejas
	Para fila<-0 Hasta 10 Con Paso 1 Hacer
		Para col<-0 Hasta 5 Con Paso 1 Hacer
			// Fila de jueces y nuetro
			Si fila = 0 Entonces
				tablaCalificaciones(fila,col) = col;
			SiNo
				// Columna participantes
				Si col = 0 Entonces
					tablaCalificaciones(fila,col) = fila;
				FinSi
			FinSi
		FinPara
	FinPara
	// Comenzar rondas
	Para ronda<-1 Hasta 5 Con Paso 1 Hacer
		Escribir "Baile #",ronda;
		Escribir "";
		// Se reinicia el vector de calificacionesParejas
		Para col<-0 Hasta 9 Con Paso 1 Hacer
			calificacionesParejas(col) = 0;
		FinPara
		// Matriz de calificaciones de los jueces
		Para fila<-1 Hasta 10 Con Paso 1 Hacer
			Para col<-1 Hasta 5 Con Paso 1 Hacer	
				// Despues de la primer ronda hay que ignorar las parejas eliminadas
				Si ronda>1 Entonces
					Si tablaCalificaciones(fila,col)<>0 Entonces
						// Calificacion del juez 
						tablaCalificaciones(fila,col) = Aleatorio(1,10);
						// Acumulacion de calificacion de la pareja
						calificacionesParejas(fila-1) = calificacionesParejas(fila-1) + tablaCalificaciones(fila,col);		
					FinSi
				SiNo
					// Calificacion del juez 
					tablaCalificaciones(fila,col) = Aleatorio(1,10);
					// Acumulacion de calificacion de la pareja
					calificacionesParejas(fila-1) = calificacionesParejas(fila-1) + tablaCalificaciones(fila,col);			
				FinSi						
			FinPara
		FinPara
		// Mostrar el resultado de la ronda 
		Escribir "Calificación de los jueces para la ronda #",ronda;
		MostrarMatriz(tablaCalificaciones);
		Escribir "Calificaciones obtenidas por pareja en la ronda #",ronda;
		MostrarVector(calificacionesParejas);
		// Calculo de acumulado parcial de calficaciones
		Para col<-0 Hasta 9 Con Paso 1 Hacer
			total(col) = total(col) + calificacionesParejas(col);
		FinPara
		// Eliminar parejas
		Si ronda < 5 Entonces
			Escribir "Parejas eliminadas:";
			// Se elimina la pareja 1
			eliminado = EliminarParticipante(calificacionesParejas);
			calificacionesParejas(eliminado) = 0;
			Escribir "Pareja #",eliminado+1;
			// Se actualiza la tabla de calificacionesParejas
			Para col<-1 Hasta 5 Con Paso 1 Hacer
				tablaCalificaciones(eliminado+1,col) = 0;
			FinPara
			// Se elimina la pareja 2
			eliminado = EliminarParticipante(calificacionesParejas);
			calificacionesParejas(eliminado) = 0;
			Escribir "Pareja #",eliminado+1;
			Escribir "";
			// Se actualiza la tabla de calificacionesParejas
			Para col<-1 Hasta 5 Con Paso 1 Hacer
				tablaCalificaciones(eliminado+1,col) = 0;
			FinPara
			//Mostrar acumulado parcial de calficaciones
			Escribir "Acumulado parcial de las calificaciones";
			MostrarVector(total);
		FinSi
		Escribir "Presione cualquier tecla para continuar...";
		Esperar Tecla;
	FinPara
	Escribir "";
	Escribir "Calificaciones totales";
	MostrarVector(total);
	Escribir "La pareja ganadora es la #",BuscarGanador(total);
	Escribir "";
FinAlgoritmo

Funcion eliminado <- EliminarParticipante ( vector )
	Definir menor,eliminado,pareja Como Entero;
	// Buscar una pareja que no este eliminada...
	Para pareja<-0 Hasta 9 Con Paso 1 Hacer
		Si vector(pareja) > 0 Entonces
			menor = vector(pareja);
			pareja = 9;
			eliminado <- pareja;
		FinSi
	FinPara
	//Busca la pareja con la menor calificacion excluyendo los eliminados
	Para pareja<-0 Hasta 9 Con Paso 1 Hacer
		Si vector(pareja) < menor y vector(pareja) <> 0 Entonces
			menor = vector(pareja);
			eliminado <- pareja;
		FinSi
	FinPara
	//Revisar empates
	Para pareja<-0 Hasta 9 Con Paso 1 Hacer
		Si vector(pareja) = menor Entonces
			Si eliminado>pareja Entonces
				eliminado<-pareja;
				pareja <- 9;
			FinSi
		FinSi
	FinPara
FinFuncion

Funcion MostrarMatriz( matriz )	
	Definir fila,col Como Entero;
	Para fila<-0 Hasta 10 Con Paso 1 Hacer
		Para col<-0 Hasta 5 Con Paso 1 Hacer
			Si matriz(fila,col)<10 Entonces
				Escribir matriz(fila,col),"   " Sin Saltar;
			SiNo
				Escribir matriz(fila,col),"  " Sin Saltar;
			FinSi
		FinPara
		Escribir "";
	FinPara
	Escribir "";
FinFuncion

Funcion MostrarVector(vector )
	Definir indice Como Entero;
	Para indice<-0 Hasta 9 Con Paso 1 Hacer
		Escribir vector(indice), " " Sin Saltar;
	FinPara
	Escribir "";
	Escribir "";
FinFuncion

Funcion ganador <- BuscarGanador ( vector )
	Definir indice,mayor,ganador Como Entero;
	mayor = vector(0);
	Para indice<-0 Hasta 9 Con Paso 1 Hacer
		Si vector(indice)>mayor Entonces
			mayor = vector(indice);
			ganador <- indice+1;
		FinSi
	FinPara
FinFuncion