using cadastroPessoa.Classes;

Console.Clear();
Console.WriteLine(@$"
============================================
|    Bem vindo ao sistema de cadastro de   |
|        Pessoas Físicas e Jurídicas       |  
============================================ 
");

Console.BackgroundColor = ConsoleColor.Green;

BarraCarregamento("Iniciando",500, 10);

Console.ResetColor();

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
============================================
|              1 - Pessoa Física           |
|              2 - Pessoa Jurídica         |
|                                          |
|              0 - Sair                    |
============================================ 
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            PessoaFIsica novaPf = new PessoaFIsica();
            PessoaFIsica metodosPF = new PessoaFIsica();
            Endereco novoEndPf = new Endereco();

            novaPf.Nome = "Fernando Greco";
            novaPf.dataNasc = new DateTime(1989, 04, 10);
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
Maior de idade:{(metodosPF.ValidarDataNasc(novaPf.dataNasc)? "Sim" : "Não")}
Imposto a ser pago: {metodosPF.PagarImposto(novaPf.Rendimento).ToString("C")}
");
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            break;
        case "2":
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
    Imposto a ser pago: {metodosPJ.PagarImposto(novaPJ.Rendimento).ToString("C")}
    "
                );
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            break;
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            Thread.Sleep(2000);
            BarraCarregamento("Finalizando",300,10);
            break;
        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Digite um valor válido");
            Console.ResetColor();
            Thread.Sleep(2000);
            break;

    }
} while (opcao != "0");



static void BarraCarregamento(string texto,int time, int quantidade)
{

    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.Write(texto);

    for (int contador = 0; contador < quantidade; contador++)
    {
        Console.Write(".");
        Thread.Sleep(time);
    }

}










