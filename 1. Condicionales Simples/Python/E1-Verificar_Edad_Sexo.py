from datetime import datetime
print(f'Fecha y Hora: {datetime.now()}')

# Entrada de Datos
edad=int(input('Ingrese edad: '))
sexo=input('Ingrese sexo [F-M]: ').upper()

#Proceso
if (edad>17) & (sexo=='F'):
    print('Eres una mujer mayor de edad')
