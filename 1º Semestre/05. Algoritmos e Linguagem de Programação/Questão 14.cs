{
// 14. Escrever um programa fonte na Linguagem C# que efetue a leitura de uma temperatura medida em graus Celsius e faça a conversão em graus Fahrenheit.

double C, F;

Console.WriteLine("Insira a temperatura em graus Celsius para verificar seu valor em graus Fahrenheit: ");
C = int.Parse(Console.ReadLine());

F = (9 * C + 160) / 5;

Console.WriteLine("A temperatura correspondente em graus Fahrenheit é {0}.", F);
            
Console.ReadKey();
}
