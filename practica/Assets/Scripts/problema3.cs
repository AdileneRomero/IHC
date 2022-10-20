using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class problema3 : MonoBehaviour
{

//PROBLEMA  
//Dado un arreglo de números enteros nums, encontrar el sub-arreglo de elementos contiguos (con al menos  un elemento) cuya suma sea la mayor entre los demás sub-arreglos, implementar una función que regrese dicha  suma. 
//Ejemplo.  
//Nums = [-2,1,-3,4,-1,2,1,-5,4] -> (4, -1, 2, 1) 
//Sum = 6 
//Nums = [1] 
//Sum = 1 

    private int[] nums = new int [9] {-2,1,-3,4,-1,2,1,-5,4};    //arreglo de numeros para sumar
    private int[] limites = new int [9] {1,2,3,4,5,6,7,8,9};     //arreglo de posiciones para limites
    private int[] arraySumas = new int [9];                      //arreglo para guardar las sumas de los diferentes arreglos


    // Start is called before the first frame update
    void Start()
    {
        int[] result = suma();           //se guarda en result el valor retornado de funcion suma
        Debug.Log("arreglo de sumas de los sub-arreglos contiguos: ["+string.Join(", ",result)+"]");
        int r = compararSumas();         //se guarda en r el valor retornado de funcion compararSumas
        Debug.Log("La mayor suma: " + r);
        int indice = detRangoArreglo();
        Debug.Log("Rango del sub-arreglo: 0-" + indice);
    }


    public int[] suma()        //funcion para sumar
    {    
        int resultado=0;       //variable para contener resultado de suma
        int max;              //variable para contener num de iteraciones
        int cpymax;           

        for(int i = 0; i < limites.Length; i++){    //ciclo for para renovar el numero de iteraciones con valores determinados en arreglo limites
            max = limites[i];                       //max toma el valor posicionado en limites[i]
            cpymax = max;                           //se copia max en cpy, para no alterar valor de max
            do{                                     //ciclo do-while
                for(int a = 0; a < max; a++){       //ciclo for finito hasta el valor de max[i]
                    resultado+=nums[a];             //se guarda en resultado la suma iterativa 
                    cpymax--;                       //se decrementa cpymax
                }
            }while(cpymax!=0);                      //ciclo que dura mientras que cpy sea diferente de cero
            arraySumas[i] = resultado;              //se guarda en arraySumas el valor de resultado
            resultado=0;                            //variable resultado se pone a 0
        }

        return arraySumas;                          //la funcion retorna arreglo arraySumas
    }

    public int compararSumas(){                             //funcion para comparar las difrentes sumas contenidas en arraySumas
        int aux = arraySumas[0];                            //se inicializa aux con contenido de indice 0 de arraySumas
     
        for(int i = 0; i< arraySumas.Length; i++){          //ciclo for para recorrer arreglo arraySumas

                if(aux > arraySumas[i]){                    //condicion para determinar si aux > arraySumas[i]
                    aux = aux;                              // verdadero, aux conserva su valor
                }else{
                    aux=arraySumas[i];                      //falso,  aux = arraySumas[i]
                }
        }
        return aux;                                         //retorno de contenido final de aux
    }

    public int detRangoArreglo(){                     //funcion que determina el indice final del subarreglo sumado

        int indiceFinal=0;                            //variable para contener indice final
        int aux = compararSumas();                    //se guarada en aux la suma mas alta 

        for(int i=0; i<arraySumas.Length; i++){       //ciclo para recorrer arreglo arraySumas
            
            if(aux == arraySumas[i]){                 //condicion para determinar el indice que contiene la posicion de la suma mas alta
                indiceFinal = i;
            }
        }
        return indiceFinal;                           //retorno de indice final
    }

   
   
}
