using ByteBank_Adm.Funcionarios;
using ByteBank_Adm.ParceiroComercial;
using ByteBank_Adm.SistemaInterno;
using ByteBank_Adm.Utilitários;

//CalcularBonificação();
UsarSistema();

void CalcularBonificação()
{
    Console.WriteLine("Boas Vindas, ao ByteBank ADM");

    GerenciadorDeBonificacoes gerenciador = new GerenciadorDeBonificacoes();
    Auxiliar joao = new Auxiliar("123.456.789-10", 2000);
    joao.Nome = "João Victor Silva";

    Diretor paula = new Diretor("109.876.543-21", 5000);
    paula.Nome = "Paula Motta";

    Desenvolvedor samya = new Desenvolvedor("713.975.314-89");
    samya.Nome = "Samya Ferraz";

    Designer andre = new Designer("987.654.321-10", 3000);
    andre.Nome = "André Marques";

    GerenteDeContas debora = new GerenteDeContas("159.164.791-05", 4100);
    debora.Nome = "Débora Martinez";

    gerenciador.Registrar(joao);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(andre);
    gerenciador.Registrar(debora);
    gerenciador.Registrar(samya);

    Console.WriteLine("Total de Funcionário: " + Funcionario.TotalDeFuncionarios);
    Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao());

    //Console.WriteLine("Bonificação: " + joao.getBonificacao());
    //Console.WriteLine("Bonificação: " + paula.getBonificacao());
    //Console.WriteLine("Bonificação: " + andre.getBonificacao());
    //Console.WriteLine("Bonificação: " + debora.getBonificacao());

    //joao.AumentarSalario();
    //Console.WriteLine("Novo salário do João: " + joao.Salario);
    //paula.AumentarSalario();
    //Console.WriteLine("Novo salário do Paula: " + paula.Salario);
    //andre.AumentarSalario();
    //Console.WriteLine("Novo salário do André: " + andre.Salario);
    //debora.AumentarSalario();
    //Console.WriteLine("Novo salário do André: " + debora.Salario);
}

void UsarSistema()
{
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor paula = new Diretor("109.876.543-21", 5000);
    paula.Nome = "Paula Motta";
    paula.Senha = "123";

    GerenteDeContas debora = new GerenteDeContas("159.164.791-05", 4100);
    debora.Nome = "Débora Martinez";
    debora.Senha = "321";

    ParceiroComercial PetMendes = new ParceiroComercial();
    PetMendes.Senha = "54321";

    sistemainterno.Logar(paula, "123");
    sistemainterno.Logar(debora, "123");
    sistemainterno.Logar(PetMendes, "54321");
}

Console.ReadKey();
