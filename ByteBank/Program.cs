using bytebank.Contas;
using bytebank.Funcionarios;
using bytebank.Titular;
using bytebank.Utilitario;

Console.WriteLine("######### SESSÃO CONTAS E CLIENTES ##############");
Cliente cliente = new Cliente();
cliente.Nome = "André Silva";
cliente.Cpf = "05265478910";
cliente.Profissao = "Analista";

ContaCorrente conta = new ContaCorrente(18,"2356-D");
conta.Titular = cliente;
conta.SetSaldo(+100);


ContaCorrente conta2 = new ContaCorrente(15,"1510-X");
conta2.Titular = new Cliente();
conta2.Titular.Nome = "José Souza";
conta2.Titular.Profissao = "Tester";
conta2.Titular.Cpf = "32145698710";
conta2.SetSaldo(300);
conta2.Sacar(100);


ContaCorrente conta4 = new ContaCorrente(18,"2010-X");
conta4.SetSaldo(500);
conta4.Titular = new Cliente();
Console.WriteLine(conta4.GetSaldo());

Console.WriteLine(ContaCorrente.TotaldeContasCriadas);


Console.WriteLine("################################");

Console.WriteLine();

Console.WriteLine("######### SESSÃO FUNCIONÁRIOS ##############");

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Malazartes";
pedro.Cpf = "12345678410";
pedro.Salario = 2000;
Console.Write("Nome: ");
Console.WriteLine(pedro.Nome);
Console.Write("Bonificação: R$");
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "0425468897";
roberta.Salario = 5000;

Console.Write("Nome: ");
Console.WriteLine(roberta.Nome);
Console.Write("Bonificação: R$");
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);