Algoritmo Premio
	Definir n1, n2, n3 Como Entero;
	// Aleatorio (li, ls)
	n1 <- Aleatorio(5,9);
	Escribir 'Numero1:', n1;
	n2 <- Aleatorio(5,9);
	Escribir 'Numero2: ', n2;
	n3 <- Aleatorio(5,9);
	Escribir 'Numero3: ', n3;
	// los 3 iguales s/100
	// 2 iguales s/50
	// No coinciden s/0
	Si n1=n2 Y n1=n3 Entonces
		Escribir 'Premio s/100';
	SiNo
		Si n1=n2 O n1=n3 O n2=n3 Entonces
			Escribir 'Premio s/50';
		SiNo
			Escribir 'No hay premio';
		FinSi
	FinSi
FinAlgoritmo
