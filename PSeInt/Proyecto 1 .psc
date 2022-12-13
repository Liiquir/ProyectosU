Algoritmo Proyecto1
	// Variables
	Definir nPaciente,categoria Como Entero;
	Definir siguiente,valido Como Logico;
	Definir dias,metodoPago,calificacion,totalDias,nSatisfechos,nInsatisfechos Como Entero;
	Definir edad,mayor,menor Como Entero;
	Definir costo,cobro,adicional,IVA Como Real;
	Definir costoDiario,totalCostos,totalAdicional,totalIVA Como Real;
	Definir evaluacion,opcion Como Caracter;
	
	siguiente = Verdadero;

	
	nPaciente = 1; // El programa siempre empieza con el paciente #1
	mayor = 0;
	menor = 140;
	totalCostos = 0;
	totalAdicional = 0;
	totalIVA = 0;
	totalDias = 0;
	nSatisfechos = 0;
	nInsatisfechos = 0;
	dias = 0;
	edad = 0;
	metodoPago = 0;
	calificacion = 0;
	adicional = 0;
	
	Mientras siguiente Hacer // Mientras el usuario siga agregando pacientes...
		//Imprimir las categorias
		valido = Verdadero;
		Escribir "Paciente #", nPaciente;
		Escribir "Menú de categorías";
		Escribir "_________________________________";
		Escribir "  Categoría    |  Costo diario   ";
		Escribir "      1        |     150.000     ";
		Escribir "      2        |     200.000     ";
		Escribir "      3        |     250.000     ";
		Escribir "      4        |     350.000     ";
		Escribir "_________________________________";
		Escribir "Dígite una opción:";
		
		Mientras valido Hacer
			Leer categoria;
			Segun categoria Hacer
				1:
					costoDiario = 150000;
					valido = Falso;
				2:
					costoDiario = 200000;
					valido = Falso;
				3:
					costoDiario = 250000;
					valido = Falso;
				4:
					costoDiario = 350000;
					valido = Falso;
				De Otro Modo:
					Escribir "Debe digitar un valor de 1 a 4, intente de nuevo.";
			FinSegun
		FinMientras
		Escribir "";
		// Recoger datos 
		Escribir "Datos del paciente";	
		Escribir "";
		//Cantidad de días
		Escribir "Dígite la cantidad de días:";
		Leer dias;
		Mientras dias <= 0 Hacer
			Escribir "¡Cantidad de días incorrecta! Dígite la cantidad de días:";
			Leer dias;	
		FinMientras;
		totalDias = totalDias + dias;
		
		// Calcular el costo de atención 
		costo = costoDiario * dias;
		totalCostos = totalCostos + costo;
		cobro = costo; // En caso de que no se realice ningun cobro adicional
		
		// Edad
		Escribir "Dígite la edad del paciente:";
		Leer edad;
		Mientras edad <= 0 Hacer
			Escribir "¡Edad incorrecta! Dígite la edad del paciente:";
			Leer edad;	
		FinMientras
		
		// Cobro adicional segun edad
		Si edad<15 o edad>70 Entonces
			adicional = cobro * 0.20;
			cobro = cobro + adicional; // Se cobra un 20% adicional
			totalAdicional = adicional;
		FinSi
		
		// Se sobreescribe la edad hasta que se procesen todos los pacientes para saber quien es el mayor
		Si edad > mayor Entonces 
			mayor = edad;
		FinSi
		
		// Se sobreescribe la edad hasta que se procesen todos los pacientes para saber quien es el menor
		Si edad < menor Entonces 
			menor = edad;
		FinSi
		// Método de pago
		valido = Verdadero;
		Escribir "Método de pago";
		Escribir "____________________________________________";
		Escribir "     Opción     |        Método             ";
		Escribir "       1        |       Efectivo            ";
		Escribir "       2        |  Tarjeta débito/crédito   ";
		Escribir "____________________________________________";
		Escribir "Dígite una opción:";
		Mientras valido Hacer
			Leer metodoPago;
			Segun metodoPago Hacer
				1:
					IVA = cobro * 0.04;
					cobro = cobro + IVA; 
					totalIVA = totalIVA + IVA;
					valido = Falso;
				2:
					IVA = 0;
					cobro = cobro + IVA; 
					totalIVA = totalIVA + IVA;
					valido = Falso;
				De Otro Modo:
					Escribir "¡Opción inválida!";
					Escribir "Dígite una opción válida:";
			FinSegun
		FinMientras
		
		// Calificación
		valido = Verdadero;
		Escribir "Calificación de la atención recibida";
		Escribir "____________________________________________";
		Escribir "     Opción     |      Calificación         ";
		Escribir "       1        |       Satisfecho          ";
		Escribir "       2        |      Insatisfecho         ";
		Escribir "____________________________________________";
		Escribir "Dígite una opción:";
		Mientras valido Hacer
			Leer calificacion;
			Segun calificacion Hacer
				1:
					evaluacion = "Satisfecho";
					nSatisfechos = nSatisfechos + 1;
					valido = Falso;
				2:
					evaluacion = "Insatisfecho";
					nInsatisfechos = nInsatisfechos + 1;
					valido = Falso;
				De Otro Modo:
					Escribir "¡Opción inválida!";
					Escribir "Dígite una opción válida:";
			FinSegun
		FinMientras
		
		//Limpiar la pantalla
		Borrar Pantalla;
		
		//Imprimir el reporte individual 
		ReporteIndividual(nPaciente,categoria,edad,metodoPago,costoDiario,dias,costo,adicional,IVA,cobro,evaluacion);
		// Añadir otro paciente
		Escribir "";
		Escribir "¿Desea procesar otro paciente? (S/N)";
		Leer opcion; 
		Mientras opcion <> "s" y opcion <> "n" Hacer
			Escribir "¡Debe presionar ´s´ (Si) o ´n´ (No)!";
			Leer opcion;
		FinMientras
		
		Si opcion = "s" Entonces
			nPaciente = nPaciente + 1;
		SiNo
			siguiente = Falso; // Para el bucle de añadir pacientes
		FinSi
		
	FinMientras
	
	// Imprime reporte final 
	Escribir "Reporte final";
	Escribir "___________________________________________________";
	Escribir "Cantidad de pacientes procesados                  :", nPaciente;
	Escribir "El costo cobro de atención por todos los pacientes:", totalCostos;
	Escribir "Costo adicional por atención                      :", totalAdicional;
	Escribir "Total IVA                                         :", totalIVA;
	Escribir "Total Facturado                                   :", totalCostos+totalAdicional+totalIVA;
	Escribir "El paciente con mayor edad                        :", mayor;
	Escribir "El paciente con menor edad                        :", menor;
	Escribir "El promedio de días de atención por paciente      :", totalDias/nPaciente;
	Escribir "% de satisfechos                                  :", (100/nPaciente)*nSatisfechos,"%";
	Escribir "% de insatisfechos                                :", (100/nPaciente)*nInsatisfechos,"%";
	Escribir "___________________________________________________";
	
FinAlgoritmo

Funcion ReporteIndividual (nPaciente,categoria,edad,metodoPago,costoDiario,dias,costo,adicional,IVA,cobro,evaluacion)
	
	Definir opcion Como Caracter;
	
	Escribir "Reporte de atención de pacientes";
	Escribir "________________________________";
	Escribir "categoria de atención : ",categoria;
	Escribir "Edad del paciente     : ",edad;
	Escribir "Tipo de pago          : ",metodoPago;
	Escribir "Costo diario          : ",costoDiario;
	Escribir "Días de atención      : ",dias;
	Escribir "Costo de atención     : ",costo;
	Escribir "Costo de adicional    : ",adicional;
	Escribir "IVA                   : ",IVA;
	Escribir "________________________________";
	Escribir "cobro a cobrar        : ",cobro;
	Escribir "";
	Escribir "Evaluación de la atención recibida: ", evaluacion;
FinFuncion
