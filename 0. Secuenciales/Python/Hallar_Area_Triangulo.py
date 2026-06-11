from datetime import datetime
print(f'Fecha y Hora: {datetime.now()}')

# Entrada de datos
base=int(input('Ingrese la base del triangulo: '))
altura=int(input('Ibgrese la altura del triangulo: '))

# Proceso
area=base*altura*0.5

# Salida
print(f'El area del triangulo es: {area} m2')