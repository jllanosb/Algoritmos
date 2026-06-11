# Variable y valor asignado

cantmemorias=int(input("Ingrese la cantidad: "))
preciomemorias=float(input("Ingrese el precio: "))
pago=0
dscto=0
if (cantmemorias>=1 & cantmemorias<=3):
    #dscto 5%
    dscto=0.05*cantmemorias*preciomemorias
elif (cantmemorias>=4 & cantmemorias<=10):
    #dscto 10%
    dscto=0.10*cantmemorias*preciomemorias
else:
    #dscto 15%
    dscto=0.15*cantmemorias*preciomemorias

pago=cantmemorias*preciomemorias-dscto
print(f'Pago por las memorias es: s/. {pago}')
print(f'Descuento obtenido: s/. {dscto}')