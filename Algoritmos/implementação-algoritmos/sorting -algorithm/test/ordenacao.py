
def selectionSort(lista):
    if(len(lista)>=2):
        for i in range(len(lista)- 1):
            for j in range(i+1,len(lista)):
                if(lista[j]<lista[i]):
                    lista[i],lista[j] = lista[j],lista[i]
def bubbleSort(lista):
    for i in range(len(lista)-1):
        troca = False
        for j in range(len(lista)-1 -i):
            if(lista[j]>lista[j+1]):
                lista[j],lista[j+1] = lista[j+1],lista[j]
                troca = True
        if(troca == False):
            break            
                
def insertionSort(lista):
    for i in range(1,len(lista)):
        temp = lista[i]
        j = i -1
        while(j>=0 and lista[j]>temp):
            lista[j+1] = lista[j]
            j-=1
        lista[j+1] = temp




lista = [50,1,3,5,6,5,6,7,2,4.50,3,3,666,44] 
            
insertionSort(lista)


for x in lista:
    print(x)



