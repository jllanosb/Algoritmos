import random
from datetime import datetime
print(f'Fecha y Hora: {datetime.now()}')

n1=random.randint(5,9)
print(f'Numero 1: {n1}')
n2=random.randint(5,9)
print(f'Numero 2: {n2}')
n3=random.randint(5,9)
print(f'Numero 3: {n3}')

if (n1==n2 & n2==n3):
    print('Premio s/ 100')
elif (n1==n2 | n1==n3 | n2==n3):
    print('Premio s/50')
else:
    print('No hay premio')