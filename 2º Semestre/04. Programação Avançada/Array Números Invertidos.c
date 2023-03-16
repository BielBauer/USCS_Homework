#include <stdio.h>
#include <locale.h>

int main()

{
	setlocale(LC_ALL, "Portuguese");
	
	int vetor[5], i, trab;
	
	for (i = 0; i < 5; i++)
	{
		printf("Entre com um valor numérico inteiro: ");
		scanf("%d", &trab);
		vetor[i] = trab;
	}
	
	for (i = 4; i >= 0; i--)
		printf("\n%d", vetor[i]);
}
