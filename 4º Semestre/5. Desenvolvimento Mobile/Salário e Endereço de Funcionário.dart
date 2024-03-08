//  1 - Cálculo de salário de funcionário em linguagem Dart.

// Deve-se criar duas classes: Funcionario e Endereco
// a) A classe funcionário deverá conter ao menos 5 atributos, onde, destes 5 atributos um deles deverá ser o endereço do funcionário,
// o qual faz referência a classe Endereco, e um método construtor.
// b) A classe endereço deverá conter ao menos 6 atributos.
// c) A classe endereço deverá possuir um método para exibir no console o endereço completo do funcionário.
// d) A classe funcionário deverá possuir um método para calcular o salário do funcionário e exibir o valor do salário líquido no console.
// d.1) Considere para o cálculo do salário a seguinte fórmula: Salário Líquido = (Salário Bruto + Bônus (%)) - Desconto(%) 
// Salário Bruto expresso em valor decimal, sendo atributo da classe funcionário.
// Bônus expresso em valor inteiro, em termos percentuais, ou seja, 15 = 15%, sendo atributo da classe funcionário.
// Desconto expresso em valor inteiro, em termos percentuais, ou seja,  3 = 3%, sendo atributo da classe funcionário.
// e) Considere os seguintes dados ao instanciar o objeto funcionário.
// e.1) Salário Bruto = 1450,00; Bônus = 15% e Desconto = 3%
	
class Endereco
{
  String rua;
  String cidade;
  String estado;
  String cep;
  String pais;
  String bairro;

  Endereco(this.rua, this.cidade, this.estado, this.cep, this.pais, this.bairro);

  void exibirEndereco()
  {
    print('Endereço: $rua, $bairro, $cidade - $estado, $cep, $pais');
  }
}

class Funcionario
{
  String nome;
  int idade;
  double salarioBruto;
  int bonus;
  int desconto;
  Endereco endereco;

  Funcionario(this.nome, this.idade, this.salarioBruto, this.bonus, this.desconto, this.endereco);

    void exibirNomeFuncionario()
  {
    stdout.writeln('Abaixo informações do Funcionário: $nome');
  }
  
  double calcularSalario()
  {
    double salarioLiquido = salarioBruto + (salarioBruto * bonus / 100) - (salarioBruto * desconto / 100);
    return salarioLiquido;
  }

  void exibirSalarioLiquido()
  {
    double salarioLiquido = calcularSalario();
    print('O salário líquido de $nome é: R\$$salarioLiquido');
  }
}

void main()
{
  Endereco endereco = Endereco('Rua Conceição, 321', 'São Caetano do Sul', 'São Paulo', 'CEP 095.30-060', 'Brasil', 'Bairro Santo Antônio');
  Funcionario funcionario = Funcionario('USCS', 55, 1450.00, 15, 3, endereco);

  funcionario.exibirNomeFuncionario();
  funcionario.endereco.exibirEndereco();
  funcionario.exibirSalarioLiquido();
}
