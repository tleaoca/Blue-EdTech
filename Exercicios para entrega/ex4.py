#04 - Utilizando funções e listas faça um programa que receba uma data no formato DD/MM/AAAA e devolva uma
# string no formato D de mesPorExtenso de AAAA. Valide a data e retorne NULL caso a data seja inválida.

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