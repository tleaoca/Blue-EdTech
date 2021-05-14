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





