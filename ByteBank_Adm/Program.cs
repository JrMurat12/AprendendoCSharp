
using ByteBank_Adm.Funcionarios;

Console.WriteLine("Boas Vindas, ao ByteBank ADM");

Funcionario joao = new Funcionario();
joao.Nome = "João Victor Silva";
joao.Cpf = "123.456.789-10";
joao.Salario = 2000;

Console.WriteLine("Nome: " + joao.Nome);
Console.WriteLine("CPF: " + joao.Cpf);
Console.WriteLine("Salário: " + joao.Salario);

Diretor paula = new Diretor();
paula.Nome = "Paula Motta";
paula.Cpf = "109.876.543-21";
paula.Salario = 5000;

Console.WriteLine("Bonificação: " + joao.getBonificacao());
Console.WriteLine("Bonificação: " + paula.getBonificacao());
Console.ReadKey();
