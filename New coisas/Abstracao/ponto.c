#include <stdlib.h> /* malloc, free, exit */
#include <stdio.h> /* printf */
#include <math.h> /* sqrt */
#include "ponto.h"

struct ponto
{
float x;
float y;
};

Ponto* cria (float x, float y)
{
    Ponto* p = (Ponto*) malloc(sizeof(Ponto));

        if (p == NULL)
        {
        printf("Memória insuficiente!\n");
        exit(1);
        }

        p->x = x;
        p->y = y;
        return p;
}

void libera (Ponto* p)
    {
    free(p);
    }

void acessa (Ponto* p, float* x, float* y)
{
*x = p->x;
*y = p->y;
}
void atribui (Ponto* p, float x, float y)
{
p->x = x;
p->y = y;
}

void operacoes (float * vetor,Ponto* p1, Ponto* p2,float resultado)
{
vetor[0] = ((p2->x) + (p1->x));
vetor[1] = ((p2->y) - (p1->y));
float dx = ((p2->x) - (p1->x));

if(dx<0)
dx = dx*-1;

float dy = ((p2->y) - (p1->y));

if(dy<0)
dy = dy*-1;

if(dy!=0)
{
atan(dx);
atan(dy);
vetor[3]=(dx/dy)/3.1415;
}
else
printf("Não existe divisão por 0! Teta = 0,00\n");
}


float distancia (Ponto* p1, Ponto* p2)
{
float dx = ((p2->x) - (p1->x));
if(dx<0)
dx = dx*-1;
float dy = ((p2->y) - (p1->y));
if(dy<0)
dy = dy*-1;
return sqrt((dx*dx) + (dy*dy));
}
