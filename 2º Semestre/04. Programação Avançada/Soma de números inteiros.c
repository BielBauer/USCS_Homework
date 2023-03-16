#include <stdio.h>
#include <locale.h>
#define true 1

int main()

{
	setlocale(LC_ALL, "Portuguese");
	
	int soma = 0, n = 0;
	
	while(true)
	{
		printf("Informe um valor inteiro qualquer ou 999 para encerrar: ");
		scanf("%d", &n);
		if (n == 999)
			break;
		else
			soma = soma + n;
	}
		
	printf("Soma = %d", soma);
	return 0;
}
