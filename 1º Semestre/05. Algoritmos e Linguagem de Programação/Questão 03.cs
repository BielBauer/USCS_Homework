{
// 3. Escrever um programa fonte na Linguagem C# que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro).
// Sabendo que esse vendedor ganha 20% de comissão sobre suas vendas efetuadas, o programa deverá informar o nome do vendedor, o salário fixo e salário no final do mês.

string nome;
double salariofixo, comissao, salariofinal, totalvendas;

Console.WriteLine("Vendedor, entre abaixo com o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Agora, entre abaixo com o valor fixo do seu salário: ");
salariofixo = double.Parse(Console.ReadLine());
Console.WriteLine("Desta vez, entre abaixo com o seu total de vendas neste mês: ");
totalvendas = double.Parse(Console.ReadLine());

comissao = totalvendas * 0.2;

salariofinal = salariofixo + comissao;

Console.WriteLine("{0}, considerando o valor fixo de seu salário, na quantia de R$ {1}, e adicionando 20% de R$ {2}, que foi o total de suas vendas no mês, seu salário deste mês será de R$ {3}.", nome, salariofixo, totalvendas, salariofinal);
Console.ReadKey();
}
