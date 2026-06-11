import math
from datetime import datetime
print(f'Fecha y Hora: {datetime.now()}')

# Entrada de datos
catetoa=int(input('Ingrese cateto a: '))
catetob=int(input('Ingrese cateto b: '))

# Proceso
c=math.sqrt(catetoa*catetoa + catetob*catetob)

# Salida de datos
print(f'La hipotenusa es: {c}')
