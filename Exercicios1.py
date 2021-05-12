'''Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. 
Calcule e mostre o total do seu salário no referido mês, sabendo-se que são descontados 11% para o Imposto de Renda, 
8% para o INSS e 5% para o sindicato, faça um programa que nos dê:
salário bruto. quanto pagou ao INSS. quanto pagou ao sindicato. o salário líquido. calcule os descontos e o 
salário líquido, conforme a tabela abaixo:
+ Salário Bruto : R$
- IR (11%) : R$
- INSS (8%) : R$
- Sindicato ( 5%) : R$
= Salário Liquido : R$'''

valor_hora = float(input('Qual o valor da hora trabalhada? R$'))
qtd_hora = float(input('Quantas horas trabalhadas? '))
salario = valor_hora * qtd_hora
ir = (salario * 0.11)
inss = (salario * 0.8)
sindicato = (salario * 0.05)
salario_liquido = (ir + inss + sindicato)
print(f'\n+ Salário Bruto: R${salario:.2f}')
print(f'- IR: R${ir:.2f}')
print(f'- INSS: R${inss:.2f}')
print(f'- Sindicato: R${sindicato:.2f}')
print(f'= Salário Líquido: R${salario_liquido:.2f}')

'''Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. Informe ao usuário a quantidades 
de latas de tinta a serem compradas e o preço total.'''

m2 = float(input('Insira o m2: '))
litros = m2 / 3
qtd_latas = round(litros / 18)
valor = qtd_latas * 80
print(f'Litros: {litros:.2f}')
print(f'Latas: {qtd_latas}')
print(f'Valor a ser gasto: R${valor:.2f}')

