{
// 12. Escrever um programa fonte na Linguagem C# que leia o nome de um aluno e as notas que ele obteve nas três provas do semestre.
// Ao final, o programa deverá informar o nome do aluno e a sua média aritmética.

string nome;
double nota1, nota2, nota3, media;

Console.WriteLine("Aluno, insira abaixo seu nome: ");
nome = (Console.ReadLine());
Console.WriteLine("Insira abaixo sua primeira nota: ");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Agora, insira abaixo sua segunda nota: ");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Desta vez, insira abaixo sua terceira nota: ");
nota3 = double.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("{0}, sua média neste semestre é de {1}.", nome, media);

Console.ReadKey();
}
