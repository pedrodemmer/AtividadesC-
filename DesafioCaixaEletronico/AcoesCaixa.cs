namespace DesafioCaixaEletronico;

public class AcoesCaixa
{
    public static double Sacar(double saldo, double dinheiro)
    {
        return saldo - dinheiro;
    }

    public static double Depositar(double saldo, double dinheiro)
    {
        return saldo + dinheiro;
    }
}