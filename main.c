#include <stdio.h>
#include <stdlib.h>

#define CANTIDAD_NUMEROS 5


int main()
{
    int i;
    float numeroUsuario;
    float acumulador = 0;
    float resultado;
    for(i=0 ; i < CANTIDAD_NUMEROS ; i++)
    {
        printf("Dame el Numero %d\n",i+1);
        scanf("%d",&numeroUsuario);
        acumulador = acumulador + numeroUsuario;
    }
    resultado = (float)acumulador / CANTIDAD_NUMEROS;
    printf("Resultado %.2f\n",resultado);
    return 0;
}
