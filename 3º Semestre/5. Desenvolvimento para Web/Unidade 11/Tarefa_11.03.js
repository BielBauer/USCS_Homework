const saudacao = (nome) => `Olá, ${nome}!`;
const nome = prompt("Digite um nome:");
const mensagem = saudacao(nome);
alert(mensagem);