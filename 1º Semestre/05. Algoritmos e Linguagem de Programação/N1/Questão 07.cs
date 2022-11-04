// 7. Escreva um programa na Linguagem C# que exiba somente os números ímpares existentes entre 2000 e 9000.

{
int x = 2000;

while (x < 9000)
    if (x % 2 != 0)
    {
        Console.WriteLine(x);
        x++;
    }
    else
        x++;
    
    Console.ReadKey();              
}
