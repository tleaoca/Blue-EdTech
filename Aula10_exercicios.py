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
