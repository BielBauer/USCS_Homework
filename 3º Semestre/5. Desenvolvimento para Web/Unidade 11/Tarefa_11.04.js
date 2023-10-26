const calcularPerimetroRetangulo = (altura, largura) => 2 * (altura + largura);
const altura = parseFloat(prompt("Digite a altura do retângulo:"));
const largura = parseFloat(prompt("Digite a largura do retângulo:"));
const perimetro = calcularPerimetroRetangulo(altura, largura);
alert(`O perímetro do retângulo é: ${perimetro}`);