        {
            // 5) Escreva um programa com a Linguagem C# para ler a nota da prova de 15 alunos, armazenando-em um vetor. Calcule e imprima média geral dos alunos.
            // Adiconalmente, o programa deverá imprimir a quantidade de alunos que estão abaixo da média.

            // Definição de Variáveis e array e entrada de valores no array:

            int i, qttd = 0;
            double soma = 0, media = 0;
            double[] numeros = new double[15];
            
            Console.WriteLine("Entre com as notas dos 15 alunos: ");

            for (i = 0; i < 15; i++)
                numeros[i] = double.Parse(Console.ReadLine());

            // Cálculo e Exibição da média geral das notas:

            for (i = 0; i < 15; i++)
                {
                soma += numeros[i];
                media = soma / numeros.Length;
                }
            Console.WriteLine("A média geral da turma foi: {0}", media);

            // Exibição da quantidade de alunos abaixo da média:

            for (i = 0; i < 15; i++)

                if (numeros[i] < media)
                    qttd += 1;
                
            Console.WriteLine("A quantidade de alunos embaixo da média é: {0}", qttd);

            Console.ReadKey();
        }
