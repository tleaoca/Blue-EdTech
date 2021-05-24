#08 - Crie um programa que leia nome, ano de nascimento e carteira de trabalho e cadastre-os (com idade) em um
# dicionário. Se por acaso a CTPS for diferente de 0, o dicionário receberá também o ano de contratação e o salário.
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