#include<stdio.h>
#include<stdlib.h>
#include"funcoes.h"


typedef struct Lista
{
    int info;
    L * proximo;
};

L * inicializaLista()
{
    return NULL;
}


L * insereL(L * l, int v)
{
    L * novo;
    novo = (L *)malloc(sizeof(L));

    if(novo != NULL)
    {
       novo->info = v;
       novo->proximo = l;
       l= novo;

    }
    return novo;

}



void imprimeLista(L * l)
{
    L * aux;
    for(aux = l; aux!=NULL; aux = aux->proximo)
    {
        printf("%d\n",aux->info);
    }


}

L * separaLista(L * l, int v)
{
        L * aux;
        L * p;

    for(aux = l; aux!=NULL; aux = aux->proximo)
    {
        if(aux->info == v)
        {
            p = aux->proximo;
            aux->proximo = NULL;
            return p;
        }

    }
return 0;
}

L * concatenaLista(L * lista, L * lista2)
{
    L * aux;
    L * aux2;


    for(aux = lista; aux!=NULL; aux = aux->proximo)
    {
        for(aux2 = lista2; aux2!=NULL; aux2 = aux2->proximo)
        {

            if(aux->proximo == NULL && aux2->info==1)
            {
                aux->proximo = aux2;

            }
        }
    }
    return aux;
}

/* L * constroi (int n, int* v)
 {
    L * vetor;
    int G;
    aux = vetor;
    for(aux = lista; aux!=NULL; aux = aux->proximo)
    {
      for(G=0; G<n; G++)
        {
             vetor->info=v[n];
        }
    }
    return vetor;
 }*/


