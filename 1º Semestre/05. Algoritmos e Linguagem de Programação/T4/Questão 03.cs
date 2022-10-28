        {
            // 3) Escreva um programa com a Linguagem C# que leia um array de 8 posições e, em seguida, leia também dois valores X e Y quaisquer correspondentes
            // à primeira e última posição do array. Ao final seu programa deverá escrever a soma dos valores encontrados nas respectivas posições X e Y.

            // Definição de Variáveis e array e entrada de valores no array:

            int i, soma = 0;
            int[] numeros = new int[8];
            
            Console.WriteLine("Entre com 8 valores numéricos inteiros: ");

            for (i = 0; i < 8; i++)
                numeros[i] = int.Parse(Console.ReadLine());

            // Exibição dos números do array:

            Console.WriteLine("Os valores armazenados no array foram: ");

            for (i = 0; i < 8; i++)
                Console.WriteLine(numeros[i]);

            // Cálculo de X e Y:

            for (i = 0; i < 8; i++)              
                soma = numeros[0] + numeros[7];
                
            Console.WriteLine("A soma dos valores de X e Y é: {0} ", soma);
                       
            Console.ReadKey();
        }
