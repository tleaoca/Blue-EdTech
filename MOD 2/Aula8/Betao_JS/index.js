const pessoa = {
    nome: "Betão",
    sobrenome: "Einstein",
    idade: 47,
    doido: false,
    imgSerio: "https://upload.wikimedia.org/wikipedia/commons/5/50/Albert_Einstein_%28Nobel%29.png",
    imgDoido: "https://www.hypeness.com.br/1/2017/08/EinsteinL3.jpg"
}

const elementoNome = document.getElementById("nome");
const elementoSobrenome = document.getElementById("sobrenome");
const elementoIdade = document.getElementById("idade");
const elementoBotao = document.getElementById("alterarHumor");

elementoNome.innerText = pessoa.nome;
elementoSobrenome.innerText = pessoa.sobrenome;
elementoIdade.innerText = pessoa.idade;

function atualizarHumor(){
    pessoa.doido = !pessoa.doido //alternando false/true
    const elementoImagem = document.getElementById("imagem");
    const elementoHumor = document.getElementById("blocoHumor");

    if(pessoa.doido){
        elementoImagem.src = pessoa.imgDoido;
        elementoHumor.innerHTML = pessoa.nome + " tá <b>DOIDO</b>";
    }
    else{
        elementoImagem.src = pessoa.imgSerio;
        elementoHumor.innerHTML = pessoa.nome + " ta <b>NORMAL</b>";
    }

}
atualizarHumor()
elementoBotao.addEventListener("click",atualizarHumor)

