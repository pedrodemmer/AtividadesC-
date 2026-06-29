namespace Exercicio25;

class Program
{
    static void Main(string[] args)
    {
        int suspeita = 0;
        string Resposta = "";
        Console.WriteLine("Digite apenas [s] Para Sim e [n] Para Não");
            
        Console.WriteLine("Telefonou para a vitima ?");
        Resposta = Console.ReadLine().ToUpper();
        if (Resposta == "S") suspeita++;
            
        Console.WriteLine("Esteve no local do crime ?");
        Resposta = Console.ReadLine().ToUpper();
        if (Resposta == "S") suspeita++;
            
        Console.WriteLine("Mora perto da vitima ?");
        Resposta = Console.ReadLine().ToUpper(); 
        if (Resposta == "S") suspeita++;
            
        Console.WriteLine("Devia para a vitima ?");
        Resposta = Console.ReadLine().ToUpper();
        if (Resposta == "S") suspeita++;
            
        Console.WriteLine("Ja trabalhou com a vitima ?");
        Resposta = Console.ReadLine().ToUpper();
        if (Resposta == "S") suspeita++;


        if (suspeita < 2) Console.WriteLine("Inocente");
        else if (suspeita < 3) Console.WriteLine("Suspeita");
        else if (suspeita < 5) Console.WriteLine("Cúmplice");
        else Console.WriteLine("Assassino");
 
    }
}