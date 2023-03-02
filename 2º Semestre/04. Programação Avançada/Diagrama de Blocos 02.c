![Questão 02!](https://user-images.githubusercontent.com/109309661/222586760-a86888e5-f01b-4a62-a432-90c75f6a9ae6.jpg)

#include <stdio.h>

int main()

{
	int C = 0;
	int S = 10;
	
	while (C <= 5)
  {
		C = C + 1;
    S = S + 2;
  }
  
	S = S + C;
	
	printf("%d", S);

	return 0;
}
