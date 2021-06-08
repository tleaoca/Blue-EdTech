#05 - Refatore o exercício 2, para que uma função receba a frase, faça todo o tratamento necessário e retorne
#  o resultado. Depois mostre na tela o resultado e a quantidade de letras foram retiradas da frase original

def remover():
    vogais = 'aeiou'
    frase = input('Digite uma frase: ')
    tamanhoFrase = len(frase)
    for n in frase:
        if n in vogais:
            frase = frase.replace(n,'')
    print(f'Frase sem vogal:\n{frase}')
    tamanhoNovo = len(frase)
    print(f'{tamanhoFrase-tamanhoNovo} vogais removidas.')
remover()










        
            
