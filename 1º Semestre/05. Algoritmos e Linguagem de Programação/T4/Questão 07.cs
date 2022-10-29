{
            // 7) Escrever um programa com a Linguagem C# para ler um array de 10 posições e atribur valor 0 para todos os elementos que possuírem valores negativos.

            // Definição de variáveis e array e entrada de valores no array:

            int i;
            double[] numeros = new double[10];
            
            Console.WriteLine("Entre com 10 valores: ");

            for (i = 0; i < 10; i++)
                numeros[i] = double.Parse(Console.ReadLine());

            // Atribuição de valor 0 aos elementos negativos:

            for (i = 0; i < 10; i++)
                {
                if (numeros[i] < 0)
                    numeros[i] = 0;
                    Console.WriteLine(numeros[i]);
                }

            Console.ReadKey();
}
