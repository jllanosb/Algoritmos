# Definir variables
precio=0.50
pago = 0
# Entrada datos
cantidad=int(input("Ingrese la cantidad de manzanas: "))

# Decision
if (cantidad > 100):
    dscto = 0.80
    pago = cantidad * precio * dscto
elif (cantidad > 20):
    dscto = 0.90
    pago = cantidad*precio*dscto
else:
    pago = cantidad * precio;

print(f"Por {cantidad} manzanas, pagaré s/. {pago}")