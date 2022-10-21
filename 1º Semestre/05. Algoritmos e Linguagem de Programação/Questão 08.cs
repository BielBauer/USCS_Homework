{
// 8. Escrever um programa fonte na Linguagem C# que informe a idade de um jogador de futebol e exiba a sua categoria,
// considerando as seguintes regras: infantil (até 13 anos), juvenil (até 17 anos) ou sênior (acima de 17 anos).

int idade;

Console.WriteLine("Jogador, entre abaixo com sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade <= 13)
    Console.WriteLine("Sua categoria é: infantil.");
else if (idade <= 17)
    Console.WriteLine("Sua categoria é: juvenil.");
else
    Console.WriteLine("Sua categoria é: sênior.");
Console.ReadKey();
}
