// Obs.: Questão original em Linguagem C#. Programa abaixo em Linguagem Java.

// 6. Considere o programa abaixo escrito na Linguagem C#:

{
		int A, B, C, R1, R2, Q1, Q2, X;
		A = 9; B = 10; C = 15;
		
		Q1 = B / A;
		Q2 = B / 6;
		
		R1 = C % A;
		R2 = B % C;
		
		if (R1 + R2 >= 5)
		{
			if (R1 > 2)
			{
				X = Q1 + Q2 + 9;
				X--;
			}
		
			else
			{
				X = Q1 + Q2 + 8;
				X--;
			}
		}
		else
		{
			X = Q1 + Q2 + 10;
			X--;
		}
		
		System.out.println("X = " + X);
	}

// Após a execução do algoritmo será exibida na console o valor:
// A) 9
// B) 10
// C) 11
// D) 12
// E) Nenhuma das alternativas anteriores
