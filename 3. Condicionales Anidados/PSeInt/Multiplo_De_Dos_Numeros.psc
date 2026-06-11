Algoritmo Multiplo_De_Dos_Numeros
	Definir n1, n2, n3 Como Entero;
	Escribir 'Ingresar el primer numero:';
	Leer n1;
	Escribir 'Ingresar el segundo numero:';
	Leer n2;
	Escribir 'Ingresar el tercer numero:';
	Leer n3;
	Si (n1 % n2==0 Y n1 % n3==0) Entonces
		Escribir n1, ' Es multiplo de', n2, ' y de ', n3;
	SiNo
		Si n1 MOD n2==0 Entonces
			Escribir n1, ' Es multiplo de ', n2, ' No ', n3;
		SiNo
			Escribir 'No es multiplo de ', n2, ' ni ', n3;
		FinSi
	FinSi
FinAlgoritmo
