const converterFahrenheitParaCelsius = (fahrenheit) => ((fahrenheit - 32) * 5) / 9;
const temperaturaFahrenheit = parseFloat(prompt("Digite a temperatura em Fahrenheit:"));
const temperaturaCelsius = converterFahrenheitParaCelsius(temperaturaFahrenheit);
alert(`A temperatura em Celsius é: ${temperaturaCelsius.toFixed(2)}`);