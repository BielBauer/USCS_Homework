const verificarMaior = (num1, num2) => num1 > num2;
const numero1 = parseFloat(prompt("Digite o primeiro número:"));
const numero2 = parseFloat(prompt("Digite o segundo número:"));
const resultado = verificarMaior(numero1, numero2);
alert(`O primeiro número é maior que o segundo: ${resultado}`);