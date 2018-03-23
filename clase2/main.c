#include <stdio.h>
#include <stdlib.h>
#define CANTIDAD_NUMEROS 5
//escribir algo para definir una funcion
//el tipo que devuelve, el nombre y,( lo que recibe)
   void imprimirMensaje (int n)
   {
       printf("ingrese el numero %d ",n+1);
   }
int main()
{
    int i;
    int numeroUsuario;
    float acumulador = 0;
    float resultado;
    int numeroMax;
    for(i=0 ; i < CANTIDAD_NUMEROS ; i++)
    {
       // printf("Dame el Numero %d\n",i+1);
       imprimirMensaje(i);
        scanf("%d",&numeroUsuario);

        if(i==0 || numeroUsuario>numeroMax)
        {
            numeroMax=numeroUsuario;
        }
        acumulador = acumulador + numeroUsuario;
    }
    resultado = (float)acumulador / CANTIDAD_NUMEROS;
    printf("Resultado %.2f\n",resultado);
    printf("el numero maximo es %d \n" ,numeroMax);
    return 0;
}

//imprimir mensaje (i)
//%d %d sumanumero(n)
