def custoAviao(nome):
    if nome == 'São Paulo':
        valorPassagem = 312
    elif nome == 'Porto Alegre':
        valorPassagem = 447
    elif nome == 'Recife':
        valorPassagem = 831
    elif nome == 'Manaus':
        valorPassagem = 986
    return valorPassagem

valor = custoAviao('Manaus')
print(valor)