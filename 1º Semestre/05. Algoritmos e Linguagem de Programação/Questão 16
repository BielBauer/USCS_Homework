{
// 16. Escrever um programa fonte na Linguagem C# que efetue a leitura de três valores numéricos inteiros (variáveis A, B e C)
// e apresente os valores entrados em ordem crescente.

int valor1, valor2, valor3;

Console.WriteLine("Insira o primeiro valor: ");
valor1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o segundo valor: ");
valor2 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o terceiro valor: ");
valor3 = int.Parse(Console.ReadLine());

if (valor1 <= valor2 && valor2 <= valor3)   
Console.WriteLine("Os valores digitados em ordem crescente: {0}, {1} e {2}.", valor1, valor2, valor3);
else if (valor1 <= valor3 && valor3 <= valor2)
Console.WriteLine("Os valores digitados em ordem crescente: {0}, {1} e {2}.", valor1, valor3, valor2);
else if (valor2 <= valor1 && valor1 <= valor3)
Console.WriteLine("Os valores digitados em ordem crescente: {0}, {1} e {2}.", valor2, valor1, valor3);
else if (valor2 <= valor3 && valor3 <= valor1)
Console.WriteLine("Os valores digitados em ordem crescente: {0}, {1} e {2}.", valor2, valor3, valor1);
else if (valor3 <= valor1 && valor1 <= valor2)
Console.WriteLine("Os valores digitados em ordem crescente: {0}, {1} e {2}.", valor3, valor1, valor2);
else
Console.WriteLine("Os valores digitados em ordem crescente: {0}, {1} e {2}.", valor3, valor2, valor1);

Console.ReadKey();
}
