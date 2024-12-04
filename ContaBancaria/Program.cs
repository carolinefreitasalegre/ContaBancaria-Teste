using ContaBancaria;

Dados dados;

Console.Write("Entre com o numero da conta: ");
int numeroConta = int.Parse(Console.ReadLine());

Console.Write("Entre com o titular da conta: ");
string nomeTitular = Console.ReadLine().ToUpper();

Console.Write("Haverá depósito inical (S/N)?");
char opcao = char.ToUpper(Console.ReadKey().KeyChar);
Console.WriteLine();

double depositoInicial = 0;
if(opcao == 'S')
{
    Console.WriteLine("Informe o valor do depósito inicial: ");
    depositoInicial = double.Parse(Console.ReadLine());
} else
{
    dados = new Dados(numeroConta,nomeTitular);
}

dados = new Dados(numeroConta, nomeTitular, depositoInicial);
Console.WriteLine("Conta cadastrada com sucesso!");
dados.ExibirDados();

Console.WriteLine("Informe o valor do depósito: ");
double valorDeposito = double.Parse(Console.ReadLine());
dados.RealizarDeposito(valorDeposito);
dados.ExibirDados();

Console.WriteLine("Informe mo valor para saque: ");
double valorSaque = double.Parse(Console.ReadLine());
dados.RealizarSaque(valorSaque);
dados.ExibirDados();

Console.WriteLine("Obrigado por utilizar nosso sistema.");
