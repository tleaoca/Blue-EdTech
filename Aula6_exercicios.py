#1.	Faça um programa, com uma função que necessite de três argumentos, e que forneça a soma desses três argumentos.

def soma(n1, n2, n3):
    total = n1 + n2 + n3
    return total

a = soma(10,20,30)
print(a)

#2. Faça um programa, com uma função que necessite de um argumento. A função retorna o valor de caractere ‘P’, 
#se seu argumento for positivo, ‘N’, se seu argumento for negativo e ‘0’ se for 0. 

def teste(a):
    if a > 0:
        print('P')
    elif a < 0:
        print('N')
    elif a == 0:
        print('0')
teste(0) 

#3. Faça um programa com uma função chamada somaImposto. A função possui dois parâmetros formais: taxaImposto, 
#que é a quantia de imposto sobre vendas expressa em porcentagem, e custo que é o custo de um item antes do imposto.
# A função “altera” o valor de custo para incluir o imposto sobre vendas.

def somaImposto(taxaImposto, custo):
    novoValor = taxaImposto / 100 * custo + custo
    return novoValor

final = somaImposto(10,500)
print(final)

#4.	Faça um programa que calcule o salário de um colaborador na empresa XYZ. O salário é pago conforme a quantidade
#de horas trabalhadas. Quando um funcionário trabalha mais de 40 horas ele recebe um adicional de 1.5 nas horas 
#extras trabalhadas.

def salario(valorHora, horas):
    if horas > 40:
        horasExtras = horas - 40
        valorExtras = horasExtras * 1.5 * valorHora
        valorSalario = valorHora * (horas - horasExtras) + valorExtras
    else:
        valorSalario = valorHora * horas
    return valorSalario

a = salario(15,45)
print(a)

#5.	Faça um programa que calcule através de uma função o IMC de uma pessoa que tenha 1,68 e pese 75kg.

def calculoimc(peso,altura):
    imc = peso / altura ** 2
    return imc

valorimc = calculoimc(105,1.75)
print(f'{valorimc:.2f}')

#6.	Escreva uma função que, dado um número nota representando a nota de um estudante, converte o valor de 
#nota para um conceito (A, B, C, D, E e F).

def notaConceito(nota):
    if nota >= 9:
        nota = 'A'
    elif nota >= 8:
        nota = 'B'
    elif nota >= 7:
        nota = 'C'
    elif nota >= 6:
        nota = 'D'
    elif nota < 6:
        nota = 'F'
    return nota

conceito = notaConceito(5.2)
print(conceito)

#7.	Escreva uma função que recebe dois parâmetros e imprime o menor dos dois. Se eles forem iguais, imprima
# que eles são iguais.

def comparar(a,b):
    if a < b:
        print(a)
    elif b < a:
        print(b)
    elif a == b:
        print('Numeros iguais')

comparar(5,3)

##DESAFIO -  Data com mês por extenso. Construa uma função que receba uma data no formato DD/MM/AAAA e devolva uma 
#string no formato D de mesPorExtenso de AAAA. Opcionalmente, valide a data e retorne NULL caso a data seja inválida.
#Considere que Fevereiro tem 28 dias e que a cada 4 anos temos ano bisexto, sendo que nesses casos Fevereiro terá 29 dias.

dia = int(input('Dia: '))
mes = int(input('Mes: '))
ano = int(input('Ano: '))

def diaExtenso(dia):
    listaDia = ["Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez", "Onze", "Doze", "Treze", "Catorzer", "Quinze", "Dezesseis", "Dezessete", "Dezoito", "Dezenove", "Vinte", "Vinte e Um", "Vinte e Dois", "Vinte e Três", "Vinte e Quatro", "Vinte e Cinco", "Vinte e Seis", "Vinte e Sete", "Vinte e Oito", "Vinte e Nove", "Trinta", "Trinta e Um"]
    diaEx = listaDia[dia-1]
    return diaEx

def mesExtenso(mes):
    listaMes = ["Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"]
    mesEx = listaMes[mes-1]
    return mesEx

print(f'{diaExtenso(dia)} de {mesExtenso(mes)} de {ano}')




