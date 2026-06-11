from datetime import datetime
print(f'Fecha y Hora: {datetime.now()}')

# Entrada Datos
celsius=int(input('Ingrese la temperatura: '))

# Proceso
f=celsius*9/5 + 32
k=celsius + 273

# Salida
print(f'{celsius}°C equivale {f} grados farenheit')
print(f'{celsius}°C equivale {k} grados kelvin')