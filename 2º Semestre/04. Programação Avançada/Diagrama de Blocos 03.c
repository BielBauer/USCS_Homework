![Questão 03](https://user-images.githubusercontent.com/109309661/222589829-5c515548-3bd9-4dd5-a1e4-bc838187f851.jpg)

#include <stdio.h>

int main()

{
	int C = 2;
	int S = 8;
	
	while (C <= 5)
	{
		C = C + 1;
		S = S + 2;
	}
	
	if (C == 5)
		S = S - C;
	
	else
		S = S + C;
	
	printf("S = %d", S);

	return 0;
}
