## Algorithme nombres premiers


Algorithme Nombre_entier  
Debut  
variables :  
nombre1, nombre2, divise : entier  
nombre1 <- 2  
nombre2 <- 1  
divise <- 0  
Pour nombre1 <- 1 à 100  
TantQue(nombre2 <= 100)  
Si(nombre1 % nombre2 == 0)  
Alors divise <- divise +1
FinTantQue   
nombre2 <- nombre2 +1  
FinPour  
Si(divise < 3)  
Alors Ecrire(nombre1)  
FinSi  
nombre1 <- nombre1 +1  
FinPour  
Fin