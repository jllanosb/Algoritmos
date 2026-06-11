Algoritmo Pago_Manzanas
	// Definir Variables
	Definir cantidad Como Entero;
	Definir precio, dscto, pago Como Real;
	// Entrada datos
	Escribir 'Ingrese la cantidad de manzanas: ';
	Leer cantidad;
	precio <- 0.50;
	// Decision >20 -->10 MOD 
	// >100 -->20 MOD , sino no hay dscto
	Si cantidad>100 Entonces
		// cantidad*precio -->100 MOD 
		// cantidad*precio*20 MOD 
		// 100 MOD -20 MOD -->80 MOD  -- 0.8
		dscto <- 0.80;
		pago <- cantidad*precio*dscto;
	SiNo
		Si cantidad>20 Entonces
			dscto <- 0.90;
			pago <- cantidad*precio*dscto;
		SiNo
			dscto <- 0;
			pago <- cantidad*precio;
		FinSi
	FinSi
	Escribir 'Por ', cantidad, ' manzanas, pagaré s/. ', pago;
FinAlgoritmo
