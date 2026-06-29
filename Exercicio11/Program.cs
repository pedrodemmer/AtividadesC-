namespace Exercicio11;

class Program
{
    static void Main(string[] args)
    {
        double salario = 0;

        Console.Write("Qual seu salario: R$");
        salario = double.Parse(Console.ReadLine());
        double percentual = salario;

        Console.WriteLine($"Salario Antes do Reajuste: R${salario}");
        if (salario <= 280)  //Aumento 20%
        {
            salario *= 1.20;
            Console.WriteLine("Aumento de 20%");
        }else if (salario <= 700)    //Aumento 15%
        {
            salario *= 1.15;
            Console.WriteLine("Aumeento de 15%");
        }else if (salario <= 1500)      //Aumento 10%
        {
            salario *= 1.10;
            Console.WriteLine("Aumento de 10%");
        } else  //Aumento 5%
        {
            salario *= 0.5;
            Console.WriteLine("Aumento de 5%");
        }
        percentual -= salario;

        Console.WriteLine("Percentual ganho: R$" + percentual*-1);
        Console.WriteLine($"Novo Salario R${salario}");
        Console.WriteLine("teste\nteste");
    }
}