from datetime import datetime
print(f'Fecha y Hora: {datetime.now()}')

prom_ponderado=float(input('Ingrese promedio ponderado: '))

if prom_ponderado>=12:	
    print("Estudiante Aprobado")
if prom_ponderado==11:	
	print("Apto para el Sustitutorio")
if prom_ponderado<10:
	print("Estudiante Desaprobado")
if prom_ponderado>17:
	print("Estudiante Sobresaliente")