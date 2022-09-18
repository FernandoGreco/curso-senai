using cadastroPessoa.Classes;
/*
PessoaFIsica novaPf = new PessoaFIsica();
PessoaFIsica metodosPF = new PessoaFIsica();
Endereco novoEndPf = new Endereco();
*/

PessoaJuridica novaPJ = new PessoaJuridica();
PessoaJuridica metodosPJ = new PessoaJuridica();
Endereco novaEndPJ = new Endereco();

novaPJ.Nome = "Blocados";
novaPJ.RazaoSocial = "Razão Social PJ";
novaPJ.Cnpj = "26.399.122/0001-96";
//novaPJ.Cnpj = "26399122000196";
novaPJ.Rendimento = 100000.5f;

novaEndPJ.logradouro = "Avenida Pedro Pinho";
novaEndPJ.numero = 720;
novaEndPJ.complemento = "Auto Elétrica";
novaEndPJ.endComercial = true;

novaPJ.Endereco = novaEndPJ;

Console.WriteLine(@$"
    Nome: {novaPJ.Nome}
    Razão Social: {novaPJ.RazaoSocial}
    CNPJ: {novaPJ.Cnpj}, Válido {metodosPJ.ValidarCnpj(novaPJ.Cnpj)}
    Endereço: {novaPJ.Endereco.logradouro}, Nº: {novaPJ.Endereco.numero}
    Complemento: {novaPJ.Endereco.complemento}
    "
    );
 
/*
novaPf.Nome = "Fernando Greco";
novaPf.dataNasc = new DateTime (1989,04,10);
novaPf.Cpf = "1324343432";
novaPf.Rendimento = 3500.5f;

novoEndPf.logradouro = "Avenida Pedro Pinho";
novoEndPf.numero = 8;
novoEndPf.complemento = "A Frente";
novoEndPf.endComercial = true;

novaPf.Endereco = novoEndPf;

Console.WriteLine($"Nome: {novaPf.Nome}");

Console.WriteLine(metodosPF.ValidarDataNasc(novaPf.dataNasc));

Console.WriteLine(novaPf.ValidarDataNasc("10/04/2010"));

Console.WriteLine(@$"
Nome:{novaPf.Nome}
Endereço:{novaPf.Endereco.logradouro},{novaPf.Endereco.numero},{novaPf.Endereco.complemento}
Maior de idade:{metodosPF.ValidarDataNasc(novaPf.dataNasc)}
");

*/
