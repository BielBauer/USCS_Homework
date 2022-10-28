{
            // 4) Escreva um programa com a Linguagem C# que leia 10 valores inteiros e, em seguida, mostre na tela os valores lidos na ordem inversa.

            // Definição de Variáveis e array e entrada de valores no array:

            int i;
            int[] numeros = new int[10];
            
            Console.WriteLine("Entre com 10 valores numéricos inteiros: ");

            for (i = 0; i < 10; i++)
                numeros[i] = int.Parse(Console.ReadLine());

            // Exibição dos números do array em ordem inversa:

            Console.WriteLine("Os valores armazenados no array, em ordem inversa, são: ");

            for (i = 9; i >= 0; i--)
                Console.WriteLine(numeros[i]);
                       
            Console.ReadKey();
}
