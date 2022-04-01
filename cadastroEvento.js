

let data_evento = '10/04/2022'
let data_atual  = Date.now()
let participantes = ['Fulano','Fulano2','Fulano3','Fulan4','Fulan5']


if(data_evento > data_atual ){
    console.log("Evento permitido")
    checkIdade(20)
}
else
console.log("Data inválida")

function checkIdade(idade){
    if(idade > 18)
    listarParticipantes()
    else
    console.log("Cadastro não permitido, idade inferior a 18 anos")
}

function listarParticipantes(){
    while (participantes.length < 100) {
        realizarCadastro()
      }
      console.log("Cadastro não permitido, limite excedido")
}

function realizarCadastro(){

}
