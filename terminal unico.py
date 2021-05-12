n1 = float(input('Nota1: '))
n2 = float(input('Nota2: ')) 
n3 = float(input('Nota3: '))

def calculoMedia(n1,n2,n3):
    if n1>n2 and n1>n3:
        nota1 = n1
    if n2>n1 and n2>n3:
        nota1 = n2
    if n3>n1 and n3>n2:
        nota1 = n3
    if n1>n2 and n2<n3:
        nota2 = n1
    if n2>n1 and n2<n3:
        nota2 = n2
    if n3>n1 and n3<n2:
        nota2 = n3
    if n1<n2 and n1<n3:
        nota3 = n1
    if n2<n1 and n2<n3:
        nota3 = n2
    if n3<n1 and n3<n2:
        nota3 = n3   
    mediaTres = (n1+n2+n3)/3
    mediaDuas = (nota1 + nota2) / 2
    print(f'Media com 3 notas: {mediaTres}')
    print(f'Media com 2 maiores notas: {mediaDuas}')
    print(f'Maior nota: {nota1}')
    print(f'Menor nota: {nota3}')


calculoMedia(n1,n2,n3)

