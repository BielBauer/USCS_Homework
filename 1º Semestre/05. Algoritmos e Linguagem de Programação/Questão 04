{
// 4. Escrever um programa fonte na Linguagem C# que leia o nome de um aluno e as notas das três provas que ele obteve no semestre, com pesos 2, 4 e 6.
// Ao final, o programa deverá exibir informar o nome do aluno e a sua média ponderada.

string nome;
double nota1, nota2, nota3, mediapond;

Console.WriteLine("Aluno, entre abaixo com o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Agora, entre abaixo com o valor de sua primeira nota: ");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Desta vez, entre abaixo com o valor da segunda nota: ");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Por fim, entre abaixo com o valor da terceira nota: ");
nota3 = double.Parse(Console.ReadLine());

mediapond = (nota1 * 2 + nota2 * 4 + nota3 * 6) / 12;

Console.WriteLine("Notas informadas: {0}, {1} e {2}.", nota1, nota2, nota3);
Console.WriteLine("{0}, de acordo com as notas informadas, a sua média ponderada neste semestre é de {1}.", nome, mediapond);
Console.ReadKey();
}
