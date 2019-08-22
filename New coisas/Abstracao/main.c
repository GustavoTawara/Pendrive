#include <stdio.h>
#include <stdlib.h>
#include "ponto.h"
#include<locale.h>

struct ponto
{
float x;
float y;
};
typedef struct ponto Ponto;

int main()
{
  setlocale(LC_ALL,"");
  float z,k,resultado;
  float vetor[3];

  Ponto *p[2];

  scanf("%f",&z);
  scanf("%f",&k);

  p[0] = cria(z,k);

  scanf("%f",&z);
  scanf("%f",&k);

  p[1] = cria(z,k);


  resultado = distancia(p[0],p[1]);
  operacoes(vetor,p[0],p[1],resultado);

    printf("resultado = %.2f\n",resultado);
    printf("\nSoma dos pontos do eixo X = %.2f",vetor[0]);
    printf("\nSubtracao dos pontos do eixo Y = %.2f\n",vetor[1]);
    printf("\nA converção de coordenadas polares resultou em P = %.2f\nTeta = %.2f\n",resultado,vetor[3]);

}
