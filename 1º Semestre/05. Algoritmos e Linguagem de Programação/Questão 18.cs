{

// 18. Escrever um programa fonte na Linguagem C# que efetue a leitura de dois valores numéricos inteiros e apresente o resultado da diferença do maior valor pelo menor.

int valor1, valor2, dif;

Console.WriteLine("Insira um valor: ");
valor1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira outro valor: ");
valor2 = int.Parse(Console.ReadLine());

if (valor1 >= valor2)
{
dif = valor1 - valor2;
Console.WriteLine("A diferença entre os dois números é {0}.", dif);
}
else
{
dif = valor2 - valor1;
Console.WriteLine("A diferença entre os dois números é {0}.", dif);
}

Console.ReadKey();
}
