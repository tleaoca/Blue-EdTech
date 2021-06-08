# 1.	Crie um código em Python que pede qual tabuada o usuário quer ver, em seguida imprima essa tabuada.

numero = int(input('Qual o numero? '))
for n in range(1,11):
    t = numero*n
    print(numero,'*',n,'=',t)

# 2.	Crie um código em Python para exibir a contagem de dígitos de um número inteiro positivo informado pelo
# usuário.

def tamanho(x):
    qtd = len(str(x))
    return qtd
num = int(input('Digite o numero:'))
print(tamanho(num))

# 3.	O Sr. Manoel Joaquim acaba de adquirir uma panificadora e pretende implantar a metodologia da tabelinha,
# que já é um sucesso na sua loja de 1,99. Você foi contratado para desenvolver o programa que monta a tabela de
# preços de pães, de 1 até 50 pães, a partir do preço do pão informado pelo usuário, conforme o exemplo abaixo: 

valorPao = float(input('Valor pao: '))
def calculo(valorPao):
    for num in range (1,51):
        valorFinal = num*valorPao
        print(num,'- R$',valorPao*num)
print(f'\n\n\n\nPreço do Pão: R${valorPao} \nPanificadora Pão de Ontem - Tabela de Preços')
calculo(valorPao)

# 4.	Crie um código em Python que receba uma lista de nomes informados pelo usuário com tamanho indefinido
# (a lista deve ser encerrada quando o usuário digitar 0) e, na sequência, receba um nome para que seja verificado
# se este consta na lista ou não. Observação: ignorar diferenças entre maiúsculas e minúsculas.

lista = []
for n in range(1000):
    nome = input('Digite o nome: ')
    if nome == '0':
        break
    if nome not in lista:
        lista.append(nome)
verificacao = input('Nome a verificar: ')
if verificacao in lista:
    print('Esta na lista')
else:
    print('Nao esta na lista')

# 5.	O Sr. Manoel Joaquim expandiu seus negócios para além dos negócios de 1,99 e agora possui uma loja de
# conveniências. Faça um programa que implemente uma caixa registradora rudimentar. O programa deverá receber um
# número desconhecido de valores referentes aos preços das mercadorias. Um valor zero deve ser informado pelo operador
# para indicar o final da compra. O programa deve então mostrar o total da compra e perguntar o valor em dinheiro que
# o cliente forneceu, para então calcular e mostrar o valor do troco. Após esta operação, o programa deverá voltar ao
# ponto inicial, para registrar a próxima compra. A saída deve ser conforme o exemplo abaixo:

valor = 1 
listaValores = []
while valor != 0:
    valor = float(input('Digite o valor: ').replace(',','.')) 
    if valor == 0:
        break
    else:
        listaValores.append(valor)
for n in range(len(listaValores)):
    print(f'Produto {n+1}: R${listaValores[n]}')
total = sum(listaValores)
dinheiro = float(input('Dinheiro: '))
troco = dinheiro-total
print(f'Total: R${total}')
print(f'Troco: R${troco}')   

# 6.	Faça um script que peça ao usuário o número de matérias da escola, ou seja, um inteiro positivo. Em seguida,
#  ele vai digitando o valor de cada nota, de cada matéria e isso será armazenado numa lista. Ao final, seu script
#  deverá fornecer a média geral do aluno.

numeroMaterias = int(input('Numero de materias: '))
notas = []
for n in range(numeroMaterias):
    notas.append(float(input('Digite a nota: ')))
somaNotas = int(sum(notas))
media = somaNotas/numeroMaterias
print(f'A media do aluno é: {media}')

# 7.	(DESAFIO) Desenvolva um código em Python que gere um número aleatório de 1 a 100 e dê ao usuário 10 chances para
# acertá-lo. A cada tentativa, deve ser impressa a quantidade de tentativas restantes e se o número aleatório é maior
# ou menor do que o número inserido na tentativa atual. Se o usuário não acertar em 10 tentativas, informe qual o número
# aleatório. [Dica: use a função randint para gerar o número aleatório]

import random
numeroA = random.randint(1,101)
contador = 0
print(numeroA)
for n in range(1,11):        
    tentativa = int(input('Qual o numero? '))
    if tentativa == numeroA:
        print('\nVocê acertou!')
        break 
    else:
        contador += 1
        restante = 10-contador 
        print(f'\n{restante} tentativas restantes\n')
        if numeroA > tentativa:
            print('O numero é maior.\n')
        else:
            print('O numero é menor.\n')
if contador > 10: 
    print('Acabaram suas tentativas')

# 8.	(DESAFIO) Escreva um programa que determine todos os números de 4 algarismos que possam ser separados em dois
# números de dois algarismos que somados e elevando-se a soma ao quadrado obtenha-se o próprio número.

listaN = []
for n in range (1000,9999):
    unidade = n // 1 % 10
    dezena = n // 10 % 10
    centena = n // 100 % 10
    milhar = n // 1000 % 10 
    fatiado1 = int(str(milhar)+str(centena))
    fatiado2 = int(str(dezena)+str(unidade))    
    if (fatiado1 + fatiado2)**2 == n:
        listaN.append(n)
        
print(listaN)