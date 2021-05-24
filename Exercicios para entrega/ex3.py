#03 - Utilizando estruturas de repetição com teste lógico, faça um programa que peça uma senha para iniciar
# seu processamento, só deixe o usuário continuar se a senha estiver correta, após entrar dê boas vindas a seu
# usuário e apresente a ele o jogo da advinhação, onde o computador vai “pensar” em um número inteiro entre 0 e 20.
# O jogador vai tentar adivinhar qual número foi escolhido até acertar, a cada palpite do usuário diga a ele se o
# número escolhido pelo computador é maior ou menor ao que ele palpitou, no final mostre quantos palpites foram
# necessários para vencer.
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


