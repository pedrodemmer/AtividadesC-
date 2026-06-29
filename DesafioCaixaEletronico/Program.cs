namespace DesafioCaixaEletronico;

class Program
{
    static void Main(string[] args)
    {
        CadastrarSaldo saldo = new CadastrarSaldo();
        Console.WriteLine("*** Caixa Eletronico ***");
        Console.Write("Cadastrar Saldo: R$");
        saldo.Cadastrar(Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine("[1] Depositar Dinheiro \n [2] Sacar Dinheiro");
        int menu = int.Parse(Console.ReadLine());

        switch (menu)
        {
            case 1:
            {
                Console.WriteLine("Quantidade Desejada para Depositar: R$");
                double dinheiro = double.Parse(Console.ReadLine());
                AcoesCaixa.Depositar(saldo, dinheiro);
                break;
            }
            case 2:
            {
                Console.WriteLine("Quantidade Desejada para Sacar: R$");
                double dinheiro = double.Parse(Console.ReadLine());
                AcoesCaixa.Sacar(saldo, dinheiro);
                break;
            }
            default: break;
        }
    }
}