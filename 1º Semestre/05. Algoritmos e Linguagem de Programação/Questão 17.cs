{
// 17. Escrever um programa fonte na Linguagem C# que efetue a leitura de quatro valores reais referentes a quatro notas escolares de um aluno e
// apresente mensagem informando que o aluno está aprovado caso o valor da média escolar seja maior ou igual a 5.
// Caso o aluno não seja aprovado, apresente mensagem informando que o aluno encontra-se reprovado.
// Ao final, além das mensagens, apresente o valor da média do aluno.

double nota1, nota2, nota3, nota4, media;

Console.WriteLine("Aluno, insira sua primeira nota: ");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a terceira nota: ");
nota3 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a quarta nota: ");
nota4 = double.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

if (media >= 5)   
Console.WriteLine("Você foi aprovado! Sua média é {0}!", media);
else
Console.WriteLine("Você foi reprovado :'(. Sua média é {0}.", media);

Console.ReadKey();
}
