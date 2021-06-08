# 1. Exercício Treino - Crie um dicionário em que suas chaves serão os números 1, 4, 5, 6,
# 7, e 9 (que podem ser armazenados em uma lista) e seus valores correspondentes
# aos quadrados desses números.
# {1: 1, 4: 16, 5: 25, 6: 36, 7: 49, 9: 81} 

dic = {1: 1, 4: 16, 5: 25, 6: 36, 7: 49, 9: 81}

# 2. Exercício Treino - Crie um dicionário em que suas chaves correspondem a números
# inteiros entre [1, 10] e cada valor associado é o número ao quadrado.
# {1: 1, 2: 4, 3: 9, 4: 16, 5: 25, 6: 36, 7: 49, 8: 64, 9: 81, 10: 100}

dic = {}
for n in range (1,11):
    dic[n] = n**2

# 3. Faça um programa que leia nome e média de um aluno, guardando também a situação
# em um dicionário. No final, mostre o conteúdo sa estrutura na tela. A média para
# aprovação é 7. Se o aluno tirar entre 5 e 6.9 está de recuperação, caso contrário é
# reprovado.

dic = {}
while True:
    if parada == 'P': break
    nome = input('Nome do aluno: ')
    media = float(input('Média do aluno: '))
    if media >= 7:
        situacao = 'Aprovado'
    elif media > 5 and media <= 6.9:
        situacao = 'Recuperação'
    else:
        situacao = 'Reprovado'
    dic[nome] = media,situacao 
    parada = input('\nP ou C').upper()

# 4. Crie um programa em que 4 jogadores, joguem um dado e tenham resultados
# aleatórios. Guarde esses resultados em um dicionário. No final coloque esse dicionário
# em ordem, sabendo que o vencedor tirou o maior número no dado. Dicas: procure
# sobre a função randint(), sleep() e itemgetter da bliblioteca operator.

import random
from operator import itemgetter
import time
lista = []
for n in range(1,5):
    jogador = input('Jogador: ')
    dado = int(random.randint(1,20))
    lista.append((jogador,dado))
    print(f'Resultado do dado do Jogador {jogador}: {dado}\n')
    time.sleep(2)
print(lista)
conv = dict(lista)
listaResultado = sorted(conv.items(),key=itemgetter(1), reverse=True)
print(listaResultado)

# 5. Crie um programa que leia nome, ano de nascimento e carteira de trabalho e cadastreos (com idade) em um dicionário. 
# Se por acaso a CTPS for diferente de 0, o dicionário receberá também o ano de contratação e o salário. 
# Calcule e acrescente , além da idade, com quantos anos a pessoa vai se aposentar. Considere que o trabalhador deve
# contribuir por 35 anos para se aposentar.

from datetime import date
dic = dict()
ct = 1
while ct != '0':
    nome = input('Nome do funcionário: ').title()
    nasc = int(input('Ano nascimento: '))
    ct = input('Carteira de trabalho: ')
    if ct != '0':
        anoC = int(input('Ano contratação: '))
        sal = float(input('Salário: '))
        anoAtual = date.today().year
        idade = anoAtual - nasc
        idadeA = (35 - (anoAtual - anoC)) + idade
        dic[nome] = (nasc,ct,anoC,sal,idadeA)
        print(dic)
        break

# DESAFIO: Crie um programa que leia nome, sexo e idade de várias pessoas,
# guardando os dados de cada pessoa em um dicionário e todos os dicionários em uma
# lista. No final, mostre:
# A) Quantas pessoas estão cadastradas.
# B) A média da idade.
# C) Uma lista com as mulheres.
# D) Uma lista com as idades que estão acima da média.
# OBS: O programa deve garantir que o sexo digitado seja válido, e que quando
# perguntar ao usuário se deseja continuar a resposta seja somente sim ou não.

