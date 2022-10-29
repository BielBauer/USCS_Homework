{
            // 8) Escrever um programa com a Linguagem C# no qual o usuário deverá informar 10 números inteiros e maiores que zero e armazená-los em um array.
            // O programa deverá exibir a soma de todos os números pares do array.

            // Definição de variáveis e array e entrada de valores no array:

            int i, soma = 0;
            int[] numeros = new int[10];
            
            Console.WriteLine("Entre com 10 valores inteiros positivos: ");

            for (i = 0; i < 10; i++)
                numeros[i] = int.Parse(Console.ReadLine());

            // Soma dos elementos pares da array:

            for (i = 0; i < 10; i++)
                {
                if (numeros[i] % 2 == 0)
                    soma += numeros[i];
                }
            Console.WriteLine("A soma dos numeros pares da array é: {0}", soma);

            Console.ReadKey();
}
