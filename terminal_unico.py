#PROJETO: Gastos com viagem -  Escrever uma aplicação utilizando funções que calcule os gastos com passagem,
#hospedagem, aluguel de carro e gastos extras de uma viagem para uma determinada cidade.

#Hospedagem - Crie uma função chamada 'custo_hotel' que receba um parâmetro (argumento) chamado 'noites'
#e retorne o custo total do hotel, sendo que 1 noite custa R$ 140,00.

def custoHotel(noites,valorNoite=140):
    custoTotal = noites*valorNoite
    return custoTotal

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

def custoCarro(dias,valorDiaria=40):
    custo = dias*valorDiaria
    if dias >= 7:
        custoFinal = custo - 50
    elif dias >= 3:
        custoFinal = custo - 20
    else:
        custoFinal = custo
    return custoFinal

def cidadeEscolhida(nomeCidade,diasViagem):
    custoViagemTotal = custoHotel(diasViagem) + custoAviao(nomeCidade) + custoCarro(diasViagem)
    return custoViagemTotal

custoGeral = cidadeEscolhida('Manaus',4)
print(custoGeral)