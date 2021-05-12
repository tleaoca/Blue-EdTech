#Exercício Treino 1 - Escreva uma função que recebe dois parâmetros (números) e imprime o menor dos dois. 
# Se eles forem iguais, imprima que são valores idênticos.

def comparar(a,b):
    if a < b:
        print(a)
    elif b < a:
        print(b)
    elif a == b:
        print('Numeros iguais')

comparar(5,3)

#Exercício Treino 2 - Escreva uma função que recebe dois números (a e b) como parâmetro e retorna True 
#caso a soma dos dois seja maior que um terceiro parâmetro, chamado limite.

def calculo(a, b):
    limite = 20
    if a+b > limite:
        print('True')
    else:
        print('False')

calculo(10,10)

#Exercício Treino 3 - Crie uma função que receba uma string como argumento e retorne a mesma string em letras maiúsculas.
#Faça uma chamada à função, passando como parâmetro uma string.

def maiuscula(palavra):
    return palavra.upper()

palavraM = maiuscula('josef')
print(palavraM)

#Exercício 4 - Crie um programa que tenha uma função chamada voto () que vai receber como parâmetro o ano de nascimento
#de uma pessoa, retornando um valor literal indicando se uma pessoa tem voto NEGADO, OPCIONAL ou OBRIGATORIO
#nas eleições. Para resolver esse exercício, pesquise sobre a função date da biblioteca Datetime.



#Exercício 5 - Faça um programa que tenha uma função chamada ficha(), que receba dois parâmetros: o nome de um jogador
#e quantos gols ele marcou. O programa deverá ser capaz de mostrar a ficha do jogador, mesmo que algum dado não tenha
#sido informado corretamente.

def ficha(nome,gols='Nao informado'):
    print(nome)
    print(gols)

ficha('Joao')

#Exercício 6 - Um professor, muito legal, fez 3 provas durante um semestre, mas só vai levar em conta as duas notas mais
#altas para calcular a média. Faça uma aplicação que peça o valor das 3 notas, mostre como seria a média com 
#essas 3 provas, a média com as 2 notas mais altas, bem como sua nota mais alta e sua nota mais baixa.

n1 = float(input('Nota1: '))
n2 = float(input('Nota2: ')) 
n3 = float(input('Nota3: '))

def calculoMedia(n1,n2,n3):
    if n1>n2 and n1>n3:
        nota1 = n1
    elif n2>n1 and n2>n3:
        nota1 = n2
    else: 
        nota1 = n3
    if n1>n2 and n1<n3:
        nota2 = n1
    elif n2>n1 and n2<n3:
        nota2 = n2
    else: 
        nota2 = n3
    if n1<n2 and n1<n3:
        nota3 = n1
    elif n2<n1 and n2<n3:
        nota3 = n2
    else: 
        nota3 = n3   
    mediaTres = (n1+n2+n3)/3
    mediaDuas = (nota1 + nota2) / 2
    print(f'Media com 3 notas: {mediaTres}')
    print(f'Media com 2 maiores notas: {mediaDuas}')
    print(f'Maior nota: {nota1}')
    print(f'Menor nota: {nota3}')
    
calculoMedia(n1,n2,n3)

#PROJETO: Gastos com viagem -  Escrever uma aplicação utilizando funções que calcule os gastos com passagem,
#hospedagem, aluguel de carro e gastos extras de uma viagem para uma determinada cidade.

#Hospedagem - Crie uma função chamada 'custo_hotel' que receba um parâmetro (argumento) chamado 'noites'
#e retorne o custo total do hotel, sendo que 1 noite custa R$ 140,00.

def custoHotel(noites,valorNoite=140):
    custoTotal = noites*valorNoite
    return custoTotal

valorFinal = custoHotel(4)
print(valorFinal)

#Passagem
#2 - Crie uma função chamada 'custo_aviao' que receba o nome da cidade e retorne o custo da passagem de avião,
# sendo que passagem para:
#- São Paulo custa R$ 312,00;
#- Porto Alegre custa R$ 447,00;
#- Recife custa R$ 831,00;
#- Manaus custa R$ 986,00.

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

#Aluguel de Carro
#3 - Crie uma função chamada 'custo_carro' que receba um parâmetro chamado 'dias'.
#- Calcule o custo do aluguel do carro sendo que:
#- A cada dia o carro custa R$ 40,00;
#- Alugando 7 dias ou +: R$ 50,00 de desconto;
#- Alugando 3 dias ou +: R$ 20,00 de desconto;
#- Você pode receber apenas um desconto;
#- Retorne o custo.





