import random
import time
import sys

class Relogio:
    def __init__(self):
        self.horas = 6
        self.minutos = 0

    def __str__(self):
        return (f"{self.horas:02d}:{self.minutos:02d}")

    def avancaTempo(self, minutos):
        self.minutos += minutos
        while(self.minutos >= 60):
            self.minutos -= 60
            self.horas += 1

class Personagem:
    def __init__(self):
        self.sujo = True
        self.fome = True
        self.medicado = False
        self.acordado = False
        self.atrasado = False
        self.dinheiro = 0
        self.salario = 100
        self.HP = 10
        self.elogio = 0
        self.advertencia = 0
        self.nome = 'Josefino'

    def __str__(self):
        return "Você está " + ("sujo" if self.sujo else "limpo")+", "+("com" if self.fome else "sem")+" fome e "+("" if self.medicado else "não ")+"tomou sua medicação. Você tem "+str(self.dinheiro)+" reais na sua conta.\nTem "+str(casa.comida)+" de comida na geladeira e "+str(casa.remedios)+" de remedio em estoque.\nAdvertências = "+str(self.advertencia)+" Elogios = "+str(self.elogio)+" HP = "+str(self.HP)
    
    def dormir(self):
        self.sujo = True
        self.fome = True
        self.medicado = False
        self.acordado = False
        self.atrasado = False

    def montar_personagem(self):
        self.genero = input("Para começar, você é Homem, Mulher ou outro? ")
        self.idade = int(input("Ótimo, e qual sua idade? "))
        self.nome = input("Bacana, e qual o seu nome? ")
        self.cor = input("E sua cor, por gentileza: ")
        self.altura = float(input("Qual sua altura? ").replace(',','.'))
        self.peso = input("Você gostaria de ser gordo ou magro? ")
        self.cabelo = input("Qual o estilo do seu cabelo? ")
        if self.cabelo.upper() == "CARECA":
            print("KKKKKKKKKKKKKKKKKKK OLHA AÍ A CABECINHA DE GUIDÃO!")
        else:
            self.cor_cabelo = input("E a cor dele? ")
            self.rosto = input("Você é feio ou bonito? ")

class Casa:
    def __init__(self):
        self.remedios = 2
        self.comida = 5

class Eventos:
    def menu_bomdia_atrasado(self):
        print("Ações:")
        print("1 - Tomar café da manhã na rua")
        print("2 - Tomar remédio")
        print("3 - Correr para o trabalho")
        print("4 - Situação atual")
        print("5 - Comprar remédio")
        print("0 - Sair do jogo!")
        print('-=-'*15)

    def menu_bomdia_seguro(self):
        print("Ações:")
        print("1 - Tomar café da manhã")
        print("2 - Tomar remédio")
        print("3 - Tomar banho")
        print("4 - Ir para o trabalho")
        print("5 - Situação atual")
        print("6 - Comprar remédio")
        print('7 - Comprar comida')
        print("0 - Sair do jogo!")
        print('-=-'*15)

    def menu_bomdia_padrao(self):
        print("Ações:")
        print("1 - Acordar")
        print("2 - Dormir mais 5 minutinhos")        
        print("0 - Sair do jogo!")
        print('-=-'*15)       

if(__name__ == "__main__"):
    dia = 1
    relogio = Relogio()
    personagem = Personagem()
    casa = Casa()
    eventos = Eventos()
    cafe_da_manha = False
    print('-=-'*15, '\n         Bem vindo ao JOGO DA VIDA.')
    print('                 ATENÇÃO!!!')
    print('5 advertências você perde o jogo;')
    print('5 elogios você recebe uma promoção, aumento \nsalarial e redução de uma advertência.')
    print('\n          Tabela de Advertências:') 
    print('- Receber reclamação no trabalho: 1  ')
    print('- Chegar atrasado no trabalho: 1  ')
    print('- Faltar o trabalho: 2')
    print('-=-'*15)
    if input('Digite 1 para criar seu personagem ou 2 para ser padrão: ') == '1': personagem.montar_personagem()
    print('-=-'*15)
    while True:
        if personagem.advertencia >= 5:
            print('-=-'*15)
            print('Você foi DEMITIDO e perdeu no JOGO DA VIDA. Tente outra vez.')
            print('-=-'*15)
            print('-=-'*15)
            sys.exit()
        elif personagem.elogio >= 5:
            personagem.salario = (personagem.salario + 50)
            print('-=-'*15)
            print(f'Você foi PROMOVIDO!!! Parabéns! Seu salário agora é {personagem.salario}')
            print('-=-'*15)
            personagem.elogio = 0
            if personagem.advertencia >= 1:
                personagem.advertencia -= 1
        while personagem.acordado == False:               
            eventos.menu_bomdia_padrao()              
            opcao = input("Escolha sua ação: ") 
            if(opcao == "1"):
                personagem.acordado = True
            elif(opcao == "2"):
                sorte_sono = random.randint(1,12)
                if(sorte_sono <= 8):
                    print('-=-'*15)
                    print("Ok, durma mais um pouco...")
                    time.sleep(0.5)
                    relogio.avancaTempo(5)
                    print('-=-'*15)
                    print("Agora são "+str(relogio)+".\n")                    
                else:
                    time.sleep(0.5)
                    print('-=-'*15)
                    print("Você dormiu mais do que o necessário e agora está atrasadíssimo!\n")
                    personagem.acordado = True
                    relogio.avancaTempo(45)
                    if relogio.horas >= 7:
                        personagem.atrasado = True
                    break
            elif(opcao == "0"):
                sys.exit()
            else:
                print("Opção inválida!")
                continue

        if (personagem.atrasado == True):
            print(str(personagem.nome)+" são "+str(relogio)+" do dia "+str(dia)+". Você tinha que sair pro trabalho até as 07:00.\n")
            eventos.menu_bomdia_atrasado()
            opcao = input("Escolha sua ação: ")
            print('-=-'*15)          
            if(opcao == "1"):
                if(personagem.dinheiro >= 15):
                    personagem.dinheiro -= 15
                    personagem.fome = False
                    print('Café da manhã na barriga!')
                    print('-=-'*15)
                    relogio.avancaTempo(15)
                else:
                    print("O café da manhã custa 15 reais, você não tem dinheiro suficiente.")
                    print('-=-'*15)  
                    relogio.avancaTempo(5)
            elif(opcao == "2"):
                if(casa.remedios > 0):
                    casa.remedios -= 1
                    personagem.medicado = True
                    print('Remédio tomado!')
                    print('-=-'*15) 
                    relogio.avancaTempo(5) 
                else:
                    print("Não tem remédio na sua casa.")
                    relogio.avancaTempo(5)
            elif(opcao == "3"):                
                print("Você foi trabalhar.")                
                print('-=-'*15)
                relogio.avancaTempo(10)
                recebido = personagem.salario
                if(not personagem.medicado):
                    print("Como você não tomou seu remédio, você ficou doente no caminho e não chegou no trabalho.")
                    recebido = 0
                    personagem.advertencia += 2
                    if casa.remedios > 0:
                        print("\nVocê chega em casa triste, toma seu remédio e vai dormir!")
                        casa.remedio -= 1
                    else:
                        print("\nVocê chega em casa para descansar e percebe que não tem remédio para tomar, você tá ferrado!")
                        personagem.HP -= 1
                elif(personagem.sujo):
                    print("Como você estava sujo, seus colegas reclamaram para seu chefe, e você levou uma advertência. Você volta para casa cabisbaixo e não consegue tomar um banho.")
                    recebido *= 0.9
                    personagem.advertencia += 1
                elif(personagem.fome):
                    print("Como você estava com fome, você trabalhou metade do que consegue trabalhar. Sendo assim você volta para casa faminto e come a primeira coisa que vê pela frente.")
                    recebido *= 0.5
                    if casa.comida > 0:
                        print("\nVocê chega em casa triste, come sua comida e vai dormir!")
                        casa.comida -= 1
                    else:
                        print("\nVocê chega em casa para descansar e percebe que não tem comida para comer, você tá ferrado!")
                        personagem.HP -= 1
                elif(relogio.atrasado()):
                    print("Como você chegou atrasado, você produziu menos do que de costume e recebeu uma advertencia.")
                    recebido *= 0.8
                    personagem.advertencia += 1
                print("Você recebeu "+str(recebido)+" reais pelo seu trabalho hoje.")
                print('-=-'*15)
                personagem.dinheiro += recebido
                personagem.dormir()
                relogio = Relogio()
                dia+=1
            elif(opcao == '4'):
                print('-=-'*15)
                print('Situação atual: ',personagem)
                print('-=-'*15)
            elif(opcao == '5'):
                if(personagem.dinheiro >= 20):
                    casa.remedios += 10
                    personagem.dinheiro -= 20
                    relogio.avancaTempo(10)
                else:
                    print("A cartela com 10 remédios custa 20 reais, você não tem dinheiro suficiente.")
                    relogio.avancaTempo(5)
            elif(opcao == "0"):
                break
        else:
            print('-=-'*15)        
            print(str(personagem.nome)+" são "+str(relogio)+" do dia "+str(dia)+". Você tem que sair pro trabalho até as 07:00 então cuidado para não atrasar.")
            eventos.menu_bomdia_seguro()
            opcao = input("Escolha sua ação: ")
            print('-=-'*15)
            if(opcao == "1"):
                if(casa.comida > 0):
                    casa.comida -= 1
                    personagem.fome = False
                    print('Café da manhã na barriga!')
                    print('-=-'*15)
                    relogio.avancaTempo(15)
                else:
                    print("Não há comida em casa.")
                    relogio.avancaTempo(5)
            elif(opcao == "2"):
                if(casa.remedios > 0):
                    casa.remedios -= 1
                    personagem.medicado = True
                    print('Remédio tomado!')
                    print('-=-'*15)  
                    relogio.avancaTempo(5)
                else:
                    print("Não tem remédio na sua casa.")
                    relogio.avancaTempo(5)
            elif(opcao == "3"):
                personagem.sujo = False
                relogio.avancaTempo(20)
                print('Banho tomado!')
                print('-=-'*15)
            elif(opcao == "4"):                
                print("Você foi trabalhar.")                
                print('-=-'*15)
                relogio.avancaTempo(10)
                if relogio.horas >= 7:
                    personagem.atrasado == True
                recebido = personagem.salario
                if(not personagem.medicado):
                    print("Como você não tomou seu remédio, você ficou doente no caminho e não chegou no trabalho. Sendo assim seu chefe lhe aplica 2 advertências.")
                    recebido = 0
                    personagem.advertencia += 2
                    if casa.remedios > 0:
                        print("\nVocê chega em casa triste, toma seu remédio e vai dormir!")
                        casa.remedios -= 1
                    else:
                        print("\nVocê chega em casa para descansar e percebe que não tem remédio para tomar, você tá ferrado!")
                        personagem.HP -= 1
                elif(personagem.sujo):
                    print("Como você estava sujo, seus colegas reclamaram para seu chefe, e você levou uma advertência. Você volta para casa cabisbaixo e não consegue tomar um banho.")
                    recebido *= 0.9
                    personagem.advertencia += 1
                elif(personagem.fome):
                    print("Como você estava com fome, você trabalhou metade do que consegue trabalhar. Sendo assim você volta para casa faminto e come a primeira coisa que vê pela frente.")
                    recebido *= 0.5
                    if casa.comida > 0:
                        print("\nVocê chega em casa triste, come sua comida e vai dormir!")
                        casa.comida -= 1
                    else:
                        print("\nVocê chega em casa para descansar e percebe que não tem comida para comer, você tá ferrado!")
                        personagem.HP -= 1
                elif(personagem.atrasado):
                    print("Como você chegou atrasado, você produziu menos do que de costume e levou uma advertência.")
                    recebido *= 0.8
                    personagem.advertencia += 1
                else:
                    print("Você chegou bem ao trabalho e conseguiu trabalhar bem, seu chefe gostou da atitude e te elogiou!")
                    personagem.elogio += 1
                print("Você recebeu "+str(recebido)+" reais pelo seu trabalho hoje.")
                print('-=-'*15)
                personagem.dinheiro += recebido
                personagem.dormir()
                relogio = Relogio()
                dia+=1
            elif(opcao == '5'):
                print('-=-'*15)
                print('Situação atual: ',personagem)
                print('-=-'*15)
            elif(opcao == '6'):
                if(personagem.dinheiro >= 20):
                    casa.remedios += 10
                    personagem.dinheiro -= 20
                    relogio.avancaTempo(10)
                    print("Comprada a cartela com 10 remédios.")
                    print('-=-'*15)
                else:
                    print("A cartela com 10 remédios custa 20 reais, você não tem dinheiro suficiente.")
                    print('-=-'*15)
                    relogio.avancaTempo(5)
            elif(opcao == '7'):
                if(personagem.dinheiro >= 30):
                    casa.comida += 5
                    personagem.dinheiro -= 30
                    relogio.avancaTempo(20)
                    print("Feira feita, adicionado 5 comidas no estoque.")
                    print('-=-'*15)
                else:
                    print("5 comidas custam 30 reais, você não tem dinheiro suficiente.")
                    print('-=-'*15)
                    relogio.avancaTempo(5)
            elif(opcao == "0"):
                break
            else:
                print("Opção inválida!")
                relogio.avancaTempo(5)
    