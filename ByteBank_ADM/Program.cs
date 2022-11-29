
using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.ParceriaComercial;
using ByteBank_ADM.SistemaInterno;
using ByteBank_ADM.Utiliátios;

Console.WriteLine("Seja bem vindo ao ByteBank ADM");

CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificação gerenciador = new GerenciadorDeBonificação();

    Designer alberto = new Designer("128.851.127-27");
    alberto.Nome = "Alberto Maia";

    Diretor andre = new Diretor("124.854.124-24");  
    andre.Nome = "Andre Santos";

    Auxiliar julia = new Auxiliar("127.857.177-77");
    julia.Nome = "Julia Santos";

    GerenteDeContas ana = new GerenteDeContas("128.851.127-27");
    ana.Nome = "Ana Oliveira";

    Desenvolvedor alice = new Desenvolvedor("129.859.129-29");
    alice.Nome = "Maria Alice";

    gerenciador.Registrar(alberto);
    gerenciador.Registrar(andre);
    gerenciador.Registrar(julia);
    gerenciador.Registrar(ana);
    gerenciador.Registrar(alice);

    Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());
}

void UsarSistema()
{
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor josue = new Diretor("122.852.122-22");
    josue.Nome = "Fernando Richard";
    josue.Senha ="1234";

    GerenteDeContas rachel = new GerenteDeContas("122.852.122-22");
    rachel.Nome = "Rachel Moon";
    rachel.Senha = "5678";

    //Funcionario alberto = new Designer("128.851.127-27");
    //alberto.Nome = "Alberto Maia";
    //alberto.Senha = "12345";

    ParceiroComercial joao = new ParceiroComercial();
    joao.Nome = "João Doido";
    joao.Senha = "1234567";

    //sistemainterno.Logar(alberto, "12345");
    sistemainterno.Logar(josue, "1234");
    sistemainterno.Logar(rachel, "5678");
    sistemainterno.Logar(joao, "1234567");


}







//double totalBonificacao;
//GerenciadorDeBonificação gerenciador = new GerenciadorDeBonificação();

//Funcionario Andre = new Funcionario("128851-27", 2000);
//Andre.Nome = "Andre Santos";
////Console.WriteLine("Total de funcionários: " + Funcionario.totalDeFuncionarios);

//Diretor AnaP = new Diretor("0121034-4", 5000);
//AnaP.Nome = "Ana Paula";
////Console.WriteLine("Total de funcionários: " + Funcionario.totalDeFuncionarios);

//Funcionario Alberto = new Diretor("12885112727", 10000);
//Alberto.Nome = "Alberto Maia";
////Console.WriteLine("Total de funcionários: " + Funcionario.totalDeFuncionarios);


//Andre.AumentarSalraio();
//Console.WriteLine("Novo salário do André: " +Andre.Salario);
//Console.WriteLine("Novo salário do Ana Paula: " + AnaP.Salario);
//Console.WriteLine("Novo salário do Alberto: " + Alberto.Salario);

////Console.WriteLine("Bonificação Ana Paula " + AnaP.getBonificacao());
////Console.WriteLine("Bonificação Andre " + Andre.getBonificacao());
////Console.WriteLine("Toal de bonificação " + gerenciador.getBonificacao());

//gerenciador.Registrar(Andre);
//gerenciador.Registrar(AnaP);
//gerenciador.Registrar(Alberto);





Console.ReadKey();  