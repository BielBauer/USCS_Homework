// 1)  Dados: 10 números digitados pelo usuário. Escreva um programa com a Linguagem C# para exibir os valores negativos
// e que calcule e exiba a média dos valores menores que zero.

        {
// Definição de Variáveis e array e entrada de valores no array:

            int i, soma = 0, contador = 0;
            double media = 0;
            int[] array = new int[10];
            
            Console.WriteLine("Entre com 10 valores numéricos inteiros: ");

            for (i = 0; i < 10; i++)
                array[i] = int.Parse(Console.ReadLine());

// Exibição dos números negativos no array:

            Console.WriteLine("Os valores negativos armazenados no array foram: ");

            for (i = 0; i < 10; i++)
            {
                if (array[i] < 0)
                    Console.WriteLine(array[i]);
            }

// Cálculo e exibição da média dos números negativos do array:

            for (i = 0; i < 10; i++)
            {
                if (array[i] < 0)
                {
                    soma += array[i];
                    contador++;
                }
            }
            media = soma / contador;
            
            Console.WriteLine("A média dos valores negativos armazenados é: {0}", media);
            
            Console.ReadKey();
        }
