using cadastroPessoa.Classes;

PessoaFIsica novaPf = new PessoaFIsica();
PessoaFIsica metodosPF = new PessoaFIsica();
Endereco novoEndPf = new Endereco();

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

