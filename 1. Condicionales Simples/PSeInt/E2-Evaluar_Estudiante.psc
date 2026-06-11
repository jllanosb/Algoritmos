Algoritmo Evaluar_Estudiante
	Definir prom_ponderado como entero;
	//Entrada de datos
	Escribir "Ingrese Promedio Ponderado: ";
	Leer prom_ponderado;
	Si prom_ponderado>=12 Entonces	
		Escribir "Estudiante Aprobado";
	Fin si
	Si prom_ponderado=11 Entonces	
		Escribir "Apto para el Sustitutorio";
	Fin si
	Si prom_ponderado<10 Entonces	
		Escribir "Estudiante Desaprobado";
	Fin si
	Si prom_ponderado>17 Entonces	
		Escribir "Estudiante Sobresaliente";
	Fin si
FinAlgoritmo
	