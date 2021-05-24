# DESAFIO: Crie um programa que leia nome, sexo e idade de várias pessoas,
# guardando os dados de cada pessoa em um dicionário e todos os dicionários em uma
# lista. No final, mostre:
# A) Quantas pessoas estão cadastradas.
# B) A média da idade.
# C) Uma lista com as mulheres.
# D) Uma lista com as idades que estão acima da média.
# OBS: O programa deve garantir que o sexo digitado seja válido, e que quando
# perguntar ao usuário se deseja continuar a resposta seja somente sim ou não.



# while True:
#     dic = {}
#     nome = input('Nome: ')
#     sexo = input('Sexo (M ou F): ').upper()
#     if sexo != 'M' and sexo != 'F':
#         print('Sexo inválido')
#     idade = int(input('Idade: '))
#     dic[nome] = {'Sexo':sexo, 'Idade':idade}
#     print(dic)
import random
numero = random.randint(0,20)

def verif():  
    cont = 0  
    for n in range(1,21):
        tent = int(input('Tente adivinhar o número: '))
        if tent == numero: 
            print(f'Parabéns, você acertou na {cont+1} tentativa!')
            break
        else:
            cont += 1
            if numero > tent: print('O número é maior que sua tentativa.')
            else: print('O número é menor que sua tentativa.')
while True:
    senha = input('Digite a senha: ')
    if senha == 'blue':
        print('Bem vindo!')
        print('-'*30)
        print('Jogo da adivinhação - Adivinhe o número entre 0 e 20')
        verif()    
        if input('Quer jogar novamente? S ou N: ').upper() == 'S':
            continue
        else: break
    else: print('Senha inválida.') 
