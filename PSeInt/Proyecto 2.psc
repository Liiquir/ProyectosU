Algoritmo Controlventas
	Definir porcentaje Como Real;
	Definir codigo Como Entero;
	Definir respuesta Como Caracter;
	Definir dia Como Entero;
	Definir marca Como Caracter;
	Definir precioBruto Como Real;
	Definir neto Como Real;
	Definir unidadesVendidas Como Entero;
	Definir totalAutos Como Entero;
	Definir totalPrecioBruto Como Real;
	Definir totalNeto Como Real;
	Definir totalAutosSemana Como Entero;
	Definir totalPrecioBrutoSemana Como Real;
	Definir DiaNetoAlto Como Real;
	Definir DiaNetobajo Como Real;
	Definir listaNetos Como Real;
	Definir  i Como Entero;
	
	Dimension listaNetos(6);
	Escribir "Agencia de autos Siglo XXI";
	Escribir "******* Control de autos por modelos *******";
	Escribir "";
	Escribir "Digite el porcentaje para los impuestos sin el signo %:";
	Leer porcentaje;
	
	Mientras porcentaje < 0 Hacer
		Escribir "El porcentaje debe ser mayor a 0";
		Leer porcentaje;
	FinMientras
	
	respuesta = "S";
	
	Mientras respuesta = "S" Hacer
		
		totalAutosSemana = 0;
		totalPrecioBrutoSemana = 0;
		DiaNetoAlto = 0;
		DiaNetobajo = 0;
		
		Escribir "Dígite el código del vendedor: ";
		Leer codigo;
		
		Para dia<-0 Hasta 5 Con Paso 1 Hacer
			
			totalAutos=0;
			totalPrecioBruto=0;
			totalNeto = 0;
			
			Escribir "¿Desea ingresar los datos del día ",dia+1,"? (S/N):";
			Leer respuesta;
			listaNetos(dia) = 0;
			Mientras respuesta <> "S" y respuesta <> "N" Hacer
				Escribir "¡Debe digitar S o N!: ";
				Leer respuesta;
			FinMientras
			
			Si respuesta = "S" Entonces
				
				Escribir "Dia #",dia+1;
				
				Mientras respuesta = "S" Hacer
					
					Escribir "";
					Escribir "Dígite la marca del carro vendido: ";
					Leer marca;
					
					Escribir "Dígite el precio bruto: ";
					Leer precioBruto;
					
					Mientras precioBruto < 2000000 Hacer
						Escribir "Debe ser un monto válido, intente de nuevo.";
						Leer precioBruto;
					FinMientras
					
					Escribir "Dígite la cantidad de unidades vendidas: ";
					Leer unidadesVendidas;
					
					Mientras unidadesVendidas <= 0 Hacer
						Escribir "¡Tiene que haber al menos 1 carro vendido!";
						Leer unidadesVendidas;
					FinMientras
					
					precioBruto=preciobruto*unidadesVendidas;
					
					totalPrecioBruto = totalPrecioBruto + precioBruto;
					totalPrecioBrutoSemana = totalPrecioBrutoSemana + totalPrecioBruto;
					
					Escribir "";
					
					totalAutos = totalAutos + unidadesVendidas;
					totalAutosSemana = totalAutosSemana + totalAutos;
					
					neto =  precioBruto*porcentaje/100+precioBruto;
					totalNeto = totalNeto + neto;
					
					listaNetos(dia) = totalNeto;
					
					ReporteVentasCarro(dia,codigo, marca, unidadesVendidas, precioBruto,neto,precioBruto*porcentaje/100);
					
					Escribir "¿Desea procesar otra marca de carro? (S/N):";
					Leer respuesta;
					
					Mientras respuesta <> "S" y respuesta <> "N" Hacer
						Escribir "¡Debe digitar S o N!: ";
						Leer respuesta;
					FinMientras
					
				FinMientras
				
				ReporteDiarioVentas(dia,codigo,totalAutos,totalPrecioBruto,totalPrecioBruto*porcentaje/100,totalNeto);
				
			FinSi
			
		FinPara
		
		Definir mayor Como Real;
		Definir menor Como Real;
		
		mayor=listaNetos(0);
		menor=listaNetos(0);
		
		Para i<-0 Hasta 5 Con Paso 1 Hacer
			Si listaNetos(i) <> 0 Entonces 
				Si listaNetos(i) > mayor Entonces
					mayor = listaNetos(i);
					DiaNetoAlto = i;
				FinSi
				Si listaNetos(i) < menor Entonces
					menor = listaNetos(i);
					DiaNetoBajo = i;
				FinSi
			FinSi
		FinPara
		
		ReporteSemanal(codigo,totalAutosSemana,totalPrecioBrutoSemana,porcentaje,DiaNetobajo,DiaNetoAlto);
		
		Escribir "Desea procesar otro vendedor (S/N): ";
		Leer respuesta;
		
		Mientras respuesta <> "S" y respuesta <> "N" Hacer
			Escribir "¡Debe digitar S o N!: ";
			Leer respuesta;
		FinMientras
		
	FinMientras
	
FinAlgoritmo

Funcion ReporteVentasCarro ( dia, codigo, marca, unidadesVendidas, precioBruto,neto,impuestos)
	
	Escribir "Reporte de ventas de una marca de carro";
	
	Segun dia Hacer
		0:
			Escribir "Día de proceso: Lunes";
		1:
			Escribir "Día de proceso: Martes";
		2:
			Escribir "Día de proceso: Miércoles";
		3:
			Escribir "Día de proceso: Jueves";
		4:
			Escribir "Día de proceso: Viernes";
		5:
			Escribir "Día de proceso: Sábado";
	FinSegun
	
	Escribir "Agente de ventas: ", codigo;
	Escribir "Venta de autos de la marca: ",marca;
	Escribir "Cantidad de carros vendidos: ",unidadesVendidas;
	Escribir "Monto total de precios brutos: ", precioBruto;
	Escribir "Monto total de impuestos: ", impuestos;
	Escribir "---------------------------------------------";
	Escribir "Monto total de las ventas: ", neto;
	Escribir "";
	
FinFuncion
Funcion ReporteDiarioVentas ( dia,codigo,totalAutos,totalPrecioBruto,totalImpuestos,totalNeto )
	
	Segun dia Hacer
		0:
			Escribir "Reporte diario de ventas del día Lunes";
		1:
			Escribir "Reporte diario de ventas del día Martes";
		2:
			Escribir "Reporte diario de ventas del día Miércoles";
		3:
			Escribir "Reporte diario de ventas del día Jueves";
		4:
			Escribir "Reporte diario de ventas del día Viernes";
		5:
			Escribir "Reporte diario de ventas del día Sábado";
	FinSegun
	
	Escribir "Vendedor: ", codigo;
	Escribir "Cantidad total de autos: ",totalAutos;
	Escribir "Monto total de precios brutos: ",totalPrecioBruto;
	Escribir "Monto total de impuestos: ",totalImpuestos;
	Escribir "---------------------------------------------";
	Escribir "Monto total de las ventas: ", totalNeto;
	
	Si totalNeto >= 20000000 Entonces
		Escribir "Día exitoso :-)";
	SiNo
		Escribir "Día negativo :-(";
	FinSi
	
	Escribir "";
FinFuncion

Funcion ReporteSemanal( codigo,totalAutosSemana,totalPrecioBrutoSemana,porcentaje,DiaNetobajo,DiaNetoAlto )
	
	Escribir "******** Reporte semanal ********";
	Escribir "Digite una tecla para ver el reporte semanal del vendedor ",codigo;
	Escribir "Vendedor ",codigo;
	Escribir "Cantidad de vehiculos vendidos en la semana                :",totalAutosSemana;
	Escribir "Monto total de precios brutos                              :",totalPrecioBrutoSemana;
	Escribir "Monto total de impuestos                                   :",totalPrecioBrutoSemana*porcentaje/100;
	Escribir "------------------------------------------------------------";
	Escribir "Monto total de precios netos                               :",totalPrecioBrutoSemana*porcentaje/100+totalPrecioBrutoSemana;
	Escribir "Dia con el monto total de precios netos más bajo           :",DiaNetobajo+1; 
	Escribir "Dia con el monto total de precios netos más alto           :",DiaNetoAlto+1;
	
FinFuncion


