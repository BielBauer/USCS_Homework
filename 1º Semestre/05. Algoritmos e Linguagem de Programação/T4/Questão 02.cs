{
// 2) Escrever um programa com a Linguagem C# para ler um conjunto de números reais, armazenando-os em um array.
// O programa deverá calcular o quadrado dos valores deste array, armazenando os resultados em outro array.
// Os conjuntos têm 10 elementos cada. Imprimir todos os conjuntos (arrays).


// Definição de Variáveis e arrays e entrada de valores no primeiro array:

            int i;
            int[] numeros = new int[10];
            int[] quadrados = new int[10];
            
            Console.WriteLine("Entre com 10 valores numéricos inteiros: ");

            for (i = 0; i < 10; i++)
                numeros[i] = int.Parse(Console.ReadLine());

// Exibição dos números do array:

            Console.WriteLine("Os valores armazenados no array foram: ");

            for (i = 0; i < 10; i++)
                Console.WriteLine(numeros[i]);

// Cálculo dos quadrados e exibição do segundo array:

            Console.WriteLine("Os quadrados dos valores armazenados no array são: ");

            for (i = 0; i < 10; i++)
            {
                quadrados[i] = numeros[i] *= numeros[i];
                Console.WriteLine(quadrados[i]);
            }
                        
            Console.ReadKey();
}
