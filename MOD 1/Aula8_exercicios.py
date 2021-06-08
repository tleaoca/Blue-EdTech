# 1.	Dada a lista L = [5, 7, 2, 9, 4, 1, 3], escreva um programa que imprima as seguintes informações:
# a.	tamanho da lista.
# b.	maior valor da lista.
# c.	menor valor da lista.
# d.	soma de todos os elementos da lista.
# e.	lista em ordem crescente.
# f.	lista em ordem decrescente.

l = [5, 7, 2 , 9, 4, 1, 3]

print(len(l))
print(max(l))
print(min(l))
print(sum(l))
l.sort()
print(l)
l.reverse()
print(l)

# 2.	Faça um jogo da forca. O programa terá uma lista de palavras lidas de um arquivo texto e escolherá
#uma aleatoriamente. O jogador poderá errar 6 vezes antes de ser enforcado.

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

# 3.	Utilizando listas faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
# •	"Telefonou para a vítima?"
# •	"Esteve no local do crime?"
# •	"Mora perto da vítima?"
# •	"Devia para a vítima?"
# •	"Já trabalhou com a vítima?"  
# O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa
# responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice"
# e 5 como "Assassino". Caso contrário, ele será classificado como "Inocente".

perguntas = ['Telefonou para a vítima?','Esteve no local do crime?','Mora perto da vítima?','Devia para a vítima?', 'Já trabalhou com a vítima?']
positivos = 0
for x in perguntas:
    pergunta = input(x).upper().strip()
    if pergunta == 'P':
        positivos += 1
if positivos < 2:
    print('Inocente')
elif positivos == 2:
    print('Suspeito')
elif positivos <= 4:
    print('Cumplice')
else:
    print('Assasino')
    
# 4.	Dada uma string com uma frase informada pelo usuário (incluindo espaços em branco), conte quantas
# vezes aparece uma vogal.

str = input('Digite uma frase: ').strip().lower()
vogais = 'aeiou'

def contagem(str):
    totalVogais = sum(str.count(n) for n in vogais)
    return  totalVogais

valor = contagem(str)
print(valor)

# 5.	Desenvolva um código que pergunte um número n para o usuário e exiba todos seus divisores. 
# Caso seja um número primo, o programa ainda deve informar que se trata de um número primo! 

n = int(input('Qual numero? '))
divisores = []
for x in range(n,0,-1):
    if (n % x == 0):
        divisores.append(x)
print(divisores)
if len(divisores) == 2:
    print('Numero primo')

# 6.	Escreva um programa onde o usuário digita uma frase e essa frase retorna sem nenhuma vogal.

frase = input('Qual a frase? ')
vogais = 'aeiou'
for letra in frase:
    if letra in vogais:
        frase = frase.replace(letra,' ')
print(frase)


