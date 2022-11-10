{
// 13. Escrever um programa fonte na Linguagem C# que receba um número e diga se o número entrado está ou não no intervalo entre 100 e 200.

int n;

Console.WriteLine("Insira um número abaixo para verificar se ele está no intervalo entre 100 e 200: ");
n = int.Parse(Console.ReadLine());

if (n >= 100 && n <= 200)
{
Console.WriteLine("O número digitado está no intervalo entre 100 e 200!");
}
else
{
Console.WriteLine("O número digitado não está no intervalo entre 100 e 200.");
}
Console.ReadKey();
}
