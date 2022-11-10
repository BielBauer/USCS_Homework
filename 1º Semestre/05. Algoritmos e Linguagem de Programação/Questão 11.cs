{
// 11. Escrever um programa fonte na Linguagem C# que receba um número inteiro do usuário e diga se ele é par ou impar.
            
int valor, restodiv;

Console.WriteLine("insira abaixo um valor para saber se é par ou ímpar: ");
valor = int.Parse(Console.ReadLine());

restodiv = valor % 2;

if (restodiv == 0)
{
Console.WriteLine("O valor informado é par!");
}
else
{
Console.WriteLine("O valor informado é ímpar!");
}
Console.ReadKey();
}
