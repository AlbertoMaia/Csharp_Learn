using bytebank;
using bytebank.Titular;

Console.WriteLine("Bem vindo ao ByteBank");

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titularnome = "Alberto Maia";
//conta1.conta = "1993-A";
//conta1.numeroagencia = 29;
//conta1.nomeagencia = "Agência Central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titularnome = "Ana Paula";
//conta2.conta = "1992-A";
//conta2.numeroagencia = 29;
//conta2.nomeagencia = "Agência Central";
//conta2.saldo = 200;

//Console.WriteLine("titular: " + conta1.titular);
//Console.WriteLine("conta: " + conta1.conta);
//Console.WriteLine("Número da Agência: " + conta1.numeroagencia);
//Console.WriteLine("Nome da Agência: " + conta1.nomeagencia);
//Console.WriteLine("Sldo em conta: " + conta1.saldo); ;

//Console.WriteLine("titular: " + conta2.titular);
//Console.WriteLine("conta: " + conta2.conta);
//Console.WriteLine("Número da Agência: " + conta2.numeroagencia);
//Console.WriteLine("Nome da Agência: " + conta2.nomeagencia);
//Console.WriteLine("Sldo em conta: " + conta2.saldo);

//Console.WriteLine("saldo AnaP pré-saque: " + conta2.saldo);
//bool saque = conta2.Sacar(50);
//Console.WriteLine("Saque realizado? " + saque);
//Console.WriteLine("Saldo Anap pós-saque: " + conta2.saldo);

//conta2.Depositar(100);
//Console.WriteLine("saldo AnaP pós depósito: " + conta2.saldo);

//Console.WriteLine("Saldo Albeto pré transferência: " + conta1.saldo);
//Console.WriteLine("Saldo AnaP pré transferência: " + conta2.saldo);

//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferência realizada com sucesso?" + transferencia);
//Console.WriteLine("Saldo Alberto pós transferência: " + conta1.saldo);
//Console.WriteLine("Saldo AnaP pós transferência: " + conta2.saldo);

//Cliente alberto = new Cliente();
//alberto.Nome = "Alberto Maia";

//ContaCorrente conta4 = new ContaCorrente(235,"12345-6");
//conta4.Titular = alberto;
//conta4.Saldo = 150.0;

//Console.WriteLine(conta4.Titular.Nome);
//Console.WriteLine(conta4.Saldo);
//Console.WriteLine(conta4.Numero_Agencia);
//Console.WriteLine(conta4.Conta);

ContaCorrente conta5 = new ContaCorrente(235, "12345-6");

ContaCorrente conta6 = new ContaCorrente(335, "11153-6");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();