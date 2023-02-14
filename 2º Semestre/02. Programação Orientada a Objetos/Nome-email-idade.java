#Classe

public class Pessoa {
    String nome;
    String email;
    int idade;
}

#Aplicação

{
        Pessoa pl;
        pl = new Pessoa ();
        pl.nome = "Lucca";
        pl.email = "lucc@uol.com.br";
        pl.idade = 19;
        
        System.out.println(pl.nome);
        System.out.println(pl.email);
        System.out.println(pl.idade);
}
