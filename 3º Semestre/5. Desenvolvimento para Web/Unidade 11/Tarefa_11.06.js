const calcularAreaCirculo = (raio) => Math.PI * raio ** 2;
const raio = parseFloat(prompt("Digite o raio do círculo:"));
const area = calcularAreaCirculo(raio);
alert(`A área do círculo é: ${area.toFixed(2)}`);