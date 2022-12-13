Algoritmo Matrizausen
	Definir NM,Dia,Area,Menu,Submenu,enter,sumash1,sumash2,sumash3,sumash4,sumash5,sumasv,ContadorLunes,ContadorMartes,ContadorMiercoles,ContarJueves,ContadorViernes Como Entero;
	Definir Inicializacion,Inicializacion2 Como Logico;
	Definir MatrizN,AsignarAleatorio, fila,columna Como Entero;
	sumash1=0;
	sumash2=0;
	sumash3=0;
	sumash4=0;
	sumash5=0;
	
	
	AsignarAleatorio <- Aleatorio(0,5);
	Menu <- 0;
	Submenu <- 0;
	Dimension MatrizN[5,5];
	Inicializacion <- Falso;
	Inicializacion2 = Falso;
	Repetir
		Escribir 'Menú de opciones';
		Repetir
			Escribir '1. Inicialización de datos';
			Escribir '2. Cargar los datos de asistencia';
			Escribir '3. Reporte de indicadores de ausencias';
			Escribir '4. Reporte del total de ausencia para cada día';
			Escribir '5. Reporte del total de ausencia por área';
			Escribir '6. Salir de menú';
			Escribir 'Ingrese la opción que desee';
			Leer Menu;
			Si (Menu<>1) Y (Menu<>2) Y (Menu<>3) Y (Menu<>4) Y (Menu<>5) Y (Menu<>6) Entonces
				Escribir 'debe digitar una opción valida';
			FinSi
		Hasta Que (Menu=1) O (Menu=2) O (Menu=3) O (Menu=4) O (Menu=5) O (Menu=6)
		Segun Menu  Hacer
			1:
				Para Dia<-0 Hasta 4 Hacer
					Para Area<-0 Hasta 4 Hacer
						
						MatrizN[Dia,Area]<-0;

					FinPara
				FinPara
				
				Escribir '                   Reporte de matriz de ausencias';
				Escribir "                 Área 1", "      Área 2","      Área 3","       Área 4";
				
				Para Dia<-0 Hasta 4 Hacer
					Escribir ,Sin Saltar;
					si dia = 0 entonces Escribir"Lunes    :    |   "; sin saltar FinSi
					si dia = 1 entonces Escribir"Martes   :    |   "; sin saltar FinSi
					si dia = 2 entonces Escribir"Miércoles:    |   "; sin saltar FinSi
					si dia = 3 entonces Escribir"Jueves   :    |   "; sin saltar FinSi
					si dia = 4 entonces Escribir"Viernes  :    |   "; sin saltar FinSi
					Para Area<-0 Hasta 3 Hacer
						
						Escribir ,MatrizN[Dia,Area],"     |      "  Sin Saltar;
					FinPara
					Escribir '';
				FinPara
				Si Menu=1 Entonces
					Inicializacion <- Verdadero;
				FinSi
				Escribir "Digite enter para continuar";
				Leer enter;
			2:
				Borrar Pantalla;
				Si Inicializacion=Verdadero Entonces
					Repetir
						Borrar Pantalla;
						Escribir 'Asignar Datos';
						Escribir '1. Llenar datos manualmente';
						Escribir '2. Llenar con datos aleatorios';
						Escribir '';
						Escribir 'Digite una opcion', Sin Saltar;
						Leer Submenu;
						Si (Submenu <> 1) Y (Submenu <> 2) Entonces
							Escribir 'Debe digitar una opcion valida';
						FinSi
					Hasta Que (Submenu = 1) O (Submenu = 2)
					Segun Submenu  Hacer
						1: Escribir "Reporte de matriz de ausencias";
							
							Para Dia=0 hasta 4 con paso 1 hacer
								
								Para Area=0 Hasta 3 Con Paso 1 hacer
										si dia = 0 entonces Escribir"Digite la cantidad de ausencias para el día Lunes", " en el área " ,Area+1; sin saltar FinSi
										si dia = 1 entonces Escribir"Digite la cantidad de ausencias para el día Martes", " en el área " ,Area+1; sin saltar FinSi
										si dia = 2 entonces Escribir"Digite la cantidad de ausencias para el día Miércoles", " en el área " ,Area+1; sin saltar FinSi
										si dia = 3 entonces Escribir"Digite la cantidad de ausencias para el día Jueves", " en el área " ,Area+1; sin saltar FinSi
										si dia = 4 entonces Escribir"Digite la cantidad de ausencias para el día Viernes", " en el área " ,Area+1;  FinSi
										
										Leer MatrizN(Dia,Area);
										Mientras MatrizN(Dia,Area) <0 o MatrizN(Dia,Area)>5 Hacer
											Escribir "El numero ingresado debe ser mayor a 0 y menor a 5";
											Leer MatrizN(Dia,Area);
										FinMientras
										
										MatrizN(Dia,4) = MatrizN(Dia,4)+MatrizN(Dia,Area);
										
								FinPara
							FinPara
							
							Para Area=0 Hasta 0 Hacer
								sumash1<-0;
								Para  Dia=0 hasta 4 Hacer
									
									sumash1<-sumash1 + MatrizN[Dia,Area];
								FinPara
							FinPara
							
							Para Area=1 Hasta 1 Hacer
								sumash2<-0;
								Para  Dia= 0 hasta 4 Hacer
									sumash2<-sumash2 + MatrizN[Dia,Area];
								FinPara
							FinPara
							
							Para Area=2 Hasta 2 Hacer
								sumash3<-0;
								Para  Dia=0 hasta 4 Hacer
									sumash3<-sumash3 + MatrizN[Dia,Area];
								FinPara
							FinPara
							
							Para Area=3 Hasta 3 Hacer
								sumash4<-0;
								Para  Dia=0 hasta 4 Hacer
									sumash4<-sumash4 + MatrizN[Dia,Area];
								FinPara
								
							FinPara
							
							Para Area=4 Hasta 4 Hacer
								sumash5<-0;
								Para  Dia=0 hasta 4 Hacer
									sumash5<-sumash5 + MatrizN[Dia,Area];
								FinPara
								
							FinPara
							
							Escribir "               Área 1", "       Área 2","      Área 3","       Área 4","       Total";
							Para Dia = 0 Hasta 4 Con Paso 1 Hacer
								si dia = 0 entonces Escribir"Lunes    :  |    "; sin saltar FinSi
								si dia = 1 entonces Escribir"Martes   :  |    "; sin saltar FinSi
								si dia = 2 entonces Escribir"Miércoles:  |    "; sin saltar FinSi
								si dia = 3 entonces Escribir"Jueves   :  |    "; sin saltar FinSi
								si dia = 4 entonces Escribir"Viernes  :  |    "; sin saltar FinSi
								
								Para Area=0 Hasta 4 Con Paso 1 Hacer
									Escribir MatrizN(Dia,Area), "     |      " Sin Saltar;
									
								FinPara
								Escribir "";
							FinPara 

							
							Escribir "";
							Escribir "Total    :  |    "       ,sumash1, "     |","      ",sumash2, "     |","      ", sumash3,"     |","      ", sumash4,"     |     ",sumash5,"     |"; 
							Escribir "Digite enter para continuar";
							Leer enter;
						2:Escribir "Reporte de matriz de ausencias";
							Escribir "                 Área 1", "        Área 2","       Área 3","        Área 4","           Total      ";
							para Dia = 0 Hasta 4 con paso 1 hacer
							
								Para Area=0 hasta 3 con paso 1 Hacer
									
									MatrizN(Dia,Area)=azar(6);
									MatrizN(Dia,4) = MatrizN(Dia,4)+MatrizN(Dia,Area);
							FinPara
						FinPara
						Para Dia=0 Hasta 4 Con Paso 1 Hacer
							si dia = 0 entonces Escribir"Lunes    :    |    "; sin saltar FinSi
							si dia = 1 entonces Escribir"Martes   :    |    "; sin saltar FinSi
							si dia = 2 entonces Escribir"Miércoles:    |    "; sin saltar FinSi
							si dia = 3 entonces Escribir"Jueves   :    |    "; sin saltar FinSi
							si dia = 4 entonces Escribir"Viernes  :    |    "; sin saltar FinSi
						
							Para Area=0 Hasta 4 Con Paso 1 Hacer
								si MatrizN(Dia,Area) >= 10 Entonces
									Escribir MatrizN(Dia,Area), "      |     " Sin Saltar;
								SiNo
									Escribir MatrizN(Dia,Area), "       |     " Sin Saltar;
								FinSi
								
						
							FinPara
							Escribir " ";
							
						FinPara
						Para Area=0 Hasta 0 Hacer
							sumash1<-0;
							Para  Dia=0 hasta 4 Hacer
								
								sumash1<-sumash1 + MatrizN[Dia,Area];
							FinPara
						FinPara
						Para Area=1 Hasta 1 Hacer
							sumash2<-0;
							Para  Dia= 0 hasta 4 Hacer
								sumash2<-sumash2 + MatrizN[Dia,Area];
							FinPara
						FinPara
						Para Area=2 Hasta 2 Hacer
							sumash3<-0;
							Para  Dia=0 hasta 4 Hacer
								sumash3<-sumash3 + MatrizN[Dia,Area];
							FinPara	
						FinPara
						Para Area=3 Hasta 3 Hacer
							sumash4<-0;
							Para  Dia=0 hasta 4 Hacer
								sumash4<-sumash4 + MatrizN[Dia,Area];
							FinPara
						FinPara
						Para Area=4 Hasta 4 Hacer
							sumash5<-0;
							Para  Dia=0 hasta 4 Hacer
								sumash5<-sumash5 + MatrizN[Dia,Area];
							FinPara
							
						FinPara
						Escribir ""; 
						Escribir "Total    :    |    "     ,sumash1, "      |","     ",sumash2, "      |","     ",sumash3 ,"      |","     " ,sumash4,"       |","     ",sumash5,"      |"; 
						
						 
				FinSegun
				SiNo
					Escribir 'Primero debe inicializar los datos para digitar esta opción';
				FinSi
				
				si (Submenu=1) o (Submenu=2) Entonces
					
						
					Inicializacion2 = Verdadero;
				FinSi
				Escribir "Digite enter para continuar";
				Leer enter;
			3:Borrar Pantalla;
				
				Si Inicializacion2=Verdadero Entonces
					escribir "Reporte de indicadores de ausencias";
					Escribir "Promedio de ausencias:", sumash5/5;
					
					
					Para Area = 4 hasta 4 Con Paso 1 Hacer
						
						
						NM=0;
						Para Dia=0 hasta 4 Con Paso 1 hacer
							
							si NM < MatrizN(Dia,Area) Entonces
								
								
								
								NM<-MatrizN(Dia,area);
								
								
								
							FinSi
							
						FinPara
						si NM=MatrizN(0,4) Entonces Escribir "Mayor día de ausencias: Lunes"; finsi
						si NM=MatrizN(1,4) Entonces Escribir "Mayor día de ausencias: Martes"; finsi
						si NM=MatrizN(2,4) Entonces Escribir "Mayor día de ausencias: Miércoles"; finsi
						si NM=MatrizN(3,4) Entonces Escribir "Mayor día de ausencias: Jueves"; finsi
						si NM=MatrizN(4,4) Entonces Escribir "Mayor día de ausencias: Viernes"; finsi
					FinPara
						
					
					
					
					
					
					
				SiNo
					Escribir 'Esta opción no puede ejecutarse si no ha sido ejecutada la opción 2.';
				
				FinSi
				Escribir "Digite enter para continuar";
				Leer enter;
			4:Borrar Pantalla;
				
				Si Inicializacion2=Verdadero Entonces
					Para Area = 4 hasta 4 Con Paso 1 Hacer
						
						Escribir "Reporte se ausencias total para cada Dia";
						
						Para Dia=4 hasta 4 Con Paso 1 hacer
							
							Escribir "Lunes    :" ,MatrizN(0,4); 
							Escribir "Martes   :",MatrizN(1,4); 
							Escribir "Miércoles:" ,MatrizN(2,4); 
							Escribir "Jueves   :",MatrizN(3,4); 
							Escribir "Viernes  :",MatrizN(4,4); 
						FinPara
						
					FinPara
					
				SiNo
					Escribir 'Esta opción no puede ejecutarse si no ha sido ejecutada la opción 2.';
					
				FinSi
				Escribir "Digite enter para continuar";
				Leer enter;
			5:Borrar Pantalla;
				
				Si Inicializacion2=Verdadero Entonces
					
			Escribir "Reporte se ausencias total para cada área";	
			Escribir"Área 1:",sumash1;
			Escribir"Área 2:",sumash2;
			Escribir"Área 3:",sumash3;
			Escribir"Área 4:",sumash4;
		SiNo
			Escribir 'Esta opción no puede ejecutarse si no ha sido ejecutada la opción 2.';
			
		FinSi
		Escribir "Digite enter para continuar";
		Leer enter;
			6:
		FinSegun
	Hasta Que Menu=6
	Escribir 'Saliendo del sistema...';
FinAlgoritmo
