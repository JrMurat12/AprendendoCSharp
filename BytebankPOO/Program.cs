using BytebankPOO;
using BytebankPOO.Titular;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!");


//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "André Silva";
//conta1.conta = "10123-X";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agência Central";
//conta1.saldo = 100;

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
//Console.WriteLine("Saldo: " + conta1.saldo);


//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Jefferson Murat";
//conta2.conta = "10134-X";
//conta2.numero_agencia = 32;
//conta2.nome_agencia = "Agência Zona Sul";
//conta2.saldo = 1000;

//Console.WriteLine("Titular: " + conta2.titular);
//Console.WriteLine("Conta: " + conta2.conta);
//Console.WriteLine("Número Agencia: " + conta2.numero_agencia);
//Console.WriteLine("Nome da Agencia: " + conta2.nome_agencia);
//Console.WriteLine("Saldo: " + conta2.saldo);


//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = "Augusto Rolim";
//conta3.conta = "10188-X";
//conta3.numero_agencia = 29;
//conta3.nome_agencia = "Agência Zona Norte";
//conta3.saldo = 576;

//Console.WriteLine("Titular: " + conta3.titular);
//Console.WriteLine("Conta: " + conta3.conta);
//Console.WriteLine("Número Agencia: " + conta3.numero_agencia);
//Console.WriteLine("Nome da Agencia: " + conta3.nome_agencia);
//Console.WriteLine("Saldo: " + conta3.saldo);


//Console.WriteLine("Saldo do Jefferson pré-saque: " + conta2.saldo);
//conta2.Sacar(50);
//Console.WriteLine("Saldo do Jefferson pós-saque: " + conta2.saldo);


//conta2.Depositar(60);
//Console.WriteLine("Saldo do Jefferson pós-depósito: " + conta2.saldo);


//Console.WriteLine("Saldo do Jefferson pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André pré-transferência: " + conta1.saldo);
//conta1.Transferir(50, conta2);

//Console.WriteLine("Saldo do Jefferson pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André pós-transferência: " + conta1.saldo);

//Cliente cliente = new Cliente();
//cliente.nome = "Jefferson Murat";
//cliente.cpf = "49314577899";
//cliente.profissao = "Programador C#";

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = new Cliente();
//conta3.conta = "2513252-X";
//conta3.numero_agencia = 35;
//conta3.nome_agencia = "Agência Zona Sul";

//Console.WriteLine(cliente.nome);
//Console.WriteLine(conta3.titular.nome);

//Cliente sarah = new Cliente();
//sarah.nome = "Sarah Silva";

//ContaCorrente conta4 = new ContaCorrente(235, "125358-X");
//conta4.Saldo = 100;
//conta4.Titular = sarah;
//Console.WriteLine(conta4.Titular.nome);
//Console.WriteLine(conta4.Saldo);
//Console.WriteLine(conta4.Numero_agencia);
//Console.WriteLine(conta4.Conta);

ContaCorrente conta5 = new ContaCorrente(235, "125358-X");

ContaCorrente conta6 = new ContaCorrente(367, "135978-X");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();
