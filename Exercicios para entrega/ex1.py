#01 - Utilizando estruturas condicionais faça um programa que pergunte ao usuário dois números e mostre:
# A soma deles;
# A multiplicação entre eles;
# A divisão inteira deles;
# Mostre na tela qual é o maior;
# Verifique se o resultado da soma é par ou impar e mostre na tela;
# Se a multiplicação entre eles for maior que 40, divida pelo resultado da divisão inteira e mostre o resultado
# na tela. Se não, mostre que a multiplicação não foi maior que 40.

n1 = int(input('Numero 1: '))
n2 = int(input('Numero 2: '))
print(f'Soma: {n1+n2}')
print(f'Multiplicação: {n1*n2}')
if n1>n2: 
    maior = n1
    menor = n2
    print(f'{n1} é o maior número')
else: 
    maior = n2
    menor = n1
    print(f'{n2} é o maior número')
if (n1+n2) % 2 == 0: print(f'A soma dos números é um número par')
else: print(f'A soma dos números é um número ímpar')
if (n1*n2)>40: print(f'Resultado da divisão: {(n1*n2)/(maior//menor)}')
else: print('Multiplicação menor que 40') 
