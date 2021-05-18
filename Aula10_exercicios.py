# Exercício 0 – Crie um laço while que vai pedir para o usuário dois números e faça a soma dos dois. Enquanto a soma
# não for 50, ele deve continuar repetindo.

n1 = 0
n2 = 0
soma = 0
while soma != 50:
    n1 = int(input('Numero 1: '))
    n2 = int(input('Numero 2: '))
    soma = n1+n2
    if soma >50: print('Tente outra vez!')
if soma == 50: print('Voce acertou!')

# Exercício 1 - Escreva um programa que pede a senha ao usuário, e só sai do looping quando digitarem corretamente
# a senha.

senha = '123'
tentativa = input('Digite a senha: ')
while tentativa != senha:
    print('Senha errada, tente outra vez')
    tentativa = input('Digite a senha: ')
print('Senha aceita.')

# Exercício 2 - Faça um programa que leia dez conjuntos de dois valores, o primeiro representando o número do aluno
# e o segundo representando a sua altura em centímetros.  Encontre o aluno mais alto e o mais baixo. Mostre o número
# do aluno mais alto e o número do aluno mais baixo, junto com suas alturas.

listaNumero = []
listaAltura = []
for n in range(1,11):
    naluno = int(input('Numero do aluno: '))
    listaNumero.append(naluno)
    altura = float(input('Altura aluno: ').replace(',','.'))
    listaAltura.append(altura)
maiorAltura = max(listaAltura)
menorAltura = min(listaAltura)
posicao1 = listaAltura.index(maiorAltura)
numeroMaior = listaNumero[posicao1]
posicao2 = listaAltura.index(menorAltura)
numeroMenor = listaNumero[posicao2]
print(listaNumero)
print(listaAltura)
print(f'Numero do maior aluno: {numeroMaior}')
print(f'Altura do maior aluno: {maiorAltura}')
print(f'Numero do menor aluno: {numeroMenor}')
print(f'Altura do menor aluno: {menorAltura}')

# Exercício 3 - Em uma eleição presidencial existem quatro candidatos. Os votos são informados por meio de código. 
# Os códigos utilizados são:
# •	1 , 2, 3  - Votos para os respectivos candidatos (você deve montar a tabela ex: 1 - Jose/ 2- João/etc)
# •	5 - Voto Nulo
# •	6 - Voto em Branco
# Faça um programa que calcule e mostre:
# •	O total de votos para cada candidato;
# •	O total de votos nulos;
# •	O total de votos em branco;
# •	A percentagem de votos nulos sobre o total de votos;
# •	A percentagem de votos em branco sobre o total de votos. Para finalizar o conjunto de votos tem-se o valor zero.

n = 1
votosJoao = 0
votosJose = 0
votosJosef = 0
votosNulo = 0
votosBranco = 0
while n != 0:
    n = int(input('Digite seu voto: '))
    if n == 1:
        votosJoao += 1
    elif n == 2:
        votosJose += 1
    elif n == 3:
        votosJosef += 1
    elif n == 4:
        votosNulo += 1
    elif n == 5:
        votosBranco += 1
totalVotos = votosBranco+votosJoao+votosJose+votosJosef+votosNulo
print(f'Joao = {votosJoao}')
print(f'Jose = {votosJose}')
print(f'Josef = {votosJosef}')
print(f'Nulo = {votosNulo}')
print(f'Branco = {votosBranco}')
print(f'Porcentagem Branco = {(votosBranco*100/totalVotos):.2f}%')
print(f'Porcentagem Nulo = {(votosNulo*100/totalVotos):.2f}%')

# Exercício 4 – Codifique um jogo da FORCA. A pessoa digita uma palavra e tem que acertar a palavra digitada.

palavra = 'CERVEJA'
palavraForca = ['_' for n in palavra] 
chances = 0
print('A palavra e: ', end=' ')
print(' '.join(palavraForca))
limiteTentativas = len(palavra) + 6
for i in range(limiteTentativas):
    if palavraForca.count('_') == 0 or chances == 6: break    
    letra = input('Digite a letra: ').upper()
    if letra in palavraForca:
        print('Letra já digitada, tente novamente: ')
        continue
    if letra in palavra:
        print('A palavra e: ', end=' ')
        for n in range(len(palavra)):
            if letra == palavra[n]:
                del palavraForca[n]
                palavraForca.insert(n,letra)
        print(' '.join(palavraForca))
    else:
        chances += 1
        if chances != 6:
            print('{} erro, tente outra vez.'.format(chances))       
if palavraForca.count('_') == 0:
    print('Parabéns! Você ganhou')
else:
    print('Você perdeu!')

# DESAFIO - Desenvolver um programa para verificar a nota do aluno em uma prova com 10 questões, o programa
# deve perguntar ao aluno a resposta de cada questão e ao final comparar com o gabarito da prova assim calcular
# o total de acertos e a nota (atribuir 1 ponto por resposta certa).  Após cada aluno utilizar o sistema deve ser
# feita uma pergunta se outro aluno vai utilizar o sistema. Após todos os alunos terem respondido informar:
# •	Maior e Menor Acerto;
# •	Total de Alunos que utilizaram o sistema;
# •	A Média das Notas da Turma.
# # Gabarito da Prova:
# # 01 - A
# # 02 - B
# # 03 - C
# # 04 - D
# # 05 - E
# # 06 - E
# # 07 - D
# # 08 - C
# # 09 - B
# # 10 - A
# Após concluir isto você poderia incrementar o programa permitindo que o professor digite o gabarito da
# prova antes dos alunos usarem o programa.

gabarito = []
alunos = []
notas = []
def cadastrarG():
    for n in range(1,11):
        n = input('Digite o gabarito da {} questão: '.format(n)).upper()
        gabarito.append(n)
def cadastrarR():
    nome = input('Nome: ')
    nota = 0
    respostas = []
    for i in range(1,11):
        resp = input('Digite a resposta {}: '.format(i)).upper()
        respostas.append(resp)
    for i in range(len(gabarito)):
        if respostas[i] == gabarito[i]:
            nota += 1
    alunos.append(nome)
    notas.append(nota)
cadastrarG()
while True:
  if input('Continuar = ENTER  Sair = 0') == '0':
    break
  cadastrarR()
print('Maior nota: {}'.format(max(notas)))
print('Menor nota: {}'.format(min(notas))) 
print('Quantidade de Alunos no sistema: {}'.format(len(alunos)))
print('Média das {} notas digitadas: {}'.format(len(notas),(sum(notas)/len(notas))))