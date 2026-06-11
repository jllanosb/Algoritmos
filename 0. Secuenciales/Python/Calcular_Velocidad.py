from datetime import datetime
print(f'Fecha y Hora: {datetime.now()}')

# Entrada Datos
distancia=int(input('Ingrese la distancia recorrida: '))
tiempo=int(input('Ingrese el tiempo transcurrido: '))

# Proceso
# Conociendo v= d/t
velocidad = distancia/tiempo

# Salida de Datos
print(f'La velocidad de viaje es: {velocidad} m/s')