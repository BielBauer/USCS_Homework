{
// 9. Escrever um programa fonte na Linguagem C# que receba dois números inteiros e informe qual deles é o menor.

int valor1, valor2;

Console.WriteLine("insira o primeiro valor: ");
valor1 = int.Parse(Console.ReadLine());
Console.WriteLine("insira o segundo valor: ");
valor2 = int.Parse(Console.ReadLine());

if (valor1 < valor2)
{
Console.WriteLine("{0} é o menor valor!", valor1);
}
else if (valor1 > valor2)
{
Console.WriteLine("{0} é o menor valor!", valor2);
}
else
{
Console.WriteLine("Os valores são iguais!");
}
Console.ReadKey();
}
