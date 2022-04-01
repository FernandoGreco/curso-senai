var listaDePeca = ["Filtro de Ar","Motor","Amortecedor"]

//verifica se quantidade de peças é menor que 10
if (listadepeca.length < 10){
    console.log("é possivel cadastrar mais peças")
} else {
    console.log("não tem mais espaço na lista")
}


let peso = 150;

//verifica se o peso da peso esta adequado
if(peso<100){
    console.log("a peça deve pesar no minimo 100g")
} else{
    console.log("A peça possui peso adequado")
}

let nomePeca = "disco de freio"

//valida se o nome da paça esta correto
if (nomePeca.length>3){
    console.log("Nome de peça adequado para o cadastro!")
}else if (nomePeca.length ==0){
console.log("O nome da peça não pode ser vazio")
}else{
    console.log("o nome deve ter mais de 3 caracteres, digite um nome adequado")
}
