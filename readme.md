## Algorithme nombres premiers


Algorithme Nombre_entier  
  
variables :  
	nombre1, nombre2, divise : entier  
Début
	nombre1 <- 2  
	nombre2 <- 1  
	divise <- 0  

Pour nombre1 <- 1 à 100  
	TantQue(nombre2 <= 100)  
		Si(nombre1 % nombre2 == 0)  
		divise <- divise +1
		FinSi	
	FinTantQue   
	nombre2 <- nombre2 +1  
FinPour  
		Si(divise < 3)  
			Ecrire(nombre1)  
		FinSi  
nombre1 <- nombre1 +1  
	FinPour  
Fin