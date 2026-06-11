from datetime import datetime
print(f'Fecha y Hora: {datetime.now()}')

n1=int(input('Ingresar el primer numero: '))
n2=int(input('Ingresar el segundo numero: '))
n3=int(input('Ingresar el tercer numero: '))

if (n1 % n2==0) & (n1 % n3==0):
	print(f'{n1} Es multiplo de {n2} y de {n3}')
elif n1 % n2==0:
	print(f'{n1} Es multiplo de {n2} y pero No de {n3}')
elif n1 % n3==0:
	print(f'{n1} Es multiplo de {n3} y pero No de {n2}')
else:
	print(f'{n1} No es multiplo de {n2} ni {n3}')