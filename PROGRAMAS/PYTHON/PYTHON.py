def ejercicio1():
    contador = 0
    invertido = 0

    # Inicio y declara variables
    numero = int(input("Buen dia. Ingrese un numero entero: "))

    numero_existente = numero

    while numero >= 1:
        digito = numero % 10
        numero //= 10
        invertido = (invertido * 10) + digito
        contador += 1

    #Ahora s� dentro de la funci�n y usando la variable correcta
    print("El numero de digitos es:", contador)
    print("El numero invertido es:", invertido)


# Llamamos a la funci�n
ejercicio1()