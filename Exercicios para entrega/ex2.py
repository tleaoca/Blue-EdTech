#02 - Utilizando estruturas de repetição com variável de controle, faça um programa que receba uma string
# com uma frase informada pelo usuário e conte quantas vezes aparece as vogais a,e,i,o,u e mostre na tela, 
# depois mostre na tela essa mesma frase sem nenhuma vogal.

vogais = 'aeiou'
frase = input('Digite uma frase: ')
for n in frase:
    if n in vogais:
       frase = frase.replace(n," ")
print(frase)