using bytebank.Contas;
using bytebank.Funcionarios;
using bytebank.SistemaInterno;
using bytebank.Titular;
using bytebank.Utilitario;

#region
//Console.WriteLine("######### SESSÃO CONTAS E CLIENTES ##############");
//Cliente cliente = new Cliente();
//cliente.Nome = "André Silva";
//cliente.Cpf = "05265478910";
//cliente.Profissao = "Analista";

//ContaCorrente conta = new ContaCorrente(18,"2356-D");
//conta.Titular = cliente;
//conta.SetSaldo(+100);


//ContaCorrente conta2 = new ContaCorrente(15,"1510-X");
//conta2.Titular = new Cliente();
//conta2.Titular.Nome = "José Souza";
//conta2.Titular.Profissao = "Tester";
//conta2.Titular.Cpf = "32145698710";
//conta2.SetSaldo(300);
//conta2.Sacar(100);


//ContaCorrente conta4 = new ContaCorrente(18,"2010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());

//Console.WriteLine(ContaCorrente.TotaldeContasCriadas);


//Console.WriteLine("################################");

#endregion

#region
//Console.WriteLine("######### SESSÃO FUNCIONÁRIOS ##############");

//Funcionario pedro = new Funcionario("12345678410",2000);
//pedro.Nome = "Pedro Malazartes";

//Console.Write("Nome: ");
//Console.WriteLine(pedro.Nome);
//Console.Write("Bonificação: R$");
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("0425468897");
//roberta.Nome = "Roberta Silva";


//Console.Write("Nome: ");
//Console.WriteLine(roberta.Nome);
//Console.Write("Bonificação: R$");
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo Salário do Pedro:" + pedro.Salario);
//Console.WriteLine("Novo Salário do Roberta:" + roberta.Salario);

    #endregion

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("04658795410");
    ulisses.Nome = "Ulisses Guimaraes";

    GerenteDeConta luciano = new GerenteDeConta("04658795410");
    luciano.Nome = "Luciano Neo";

    Designer maycon = new Designer("04658795410");
    maycon.Nome = "Maycon José";

    Diretor paula = new Diretor("04658795410");
    paula.Nome = "Paula Tejano";

    Auxiliar igor = new Auxiliar("04658795410");
    igor.Nome = "Igor Naveia";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(luciano);
    gerenciador.Registrar(maycon);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);

    Console.WriteLine("Total de bonificação: " + gerenciador.TotalDeBonificacao);
}



void UsarSistema(){
    SistemaInterno sistema = new SistemaInterno();
    
    Diretor ingrid = new Diretor("12345603454");
    ingrid.Nome = "Ingrid Ramos";
    ingrid.Senha = "1234";

    GerenteDeConta ursula = new GerenteDeConta("87456123546");
    ursula.Nome = "Ursula Bezerra";
    ursula.Senha = "4321";



    sistema.Logar(ingrid, "1234");
    sistema.Logar(ursula, "121");

}

UsarSistema();