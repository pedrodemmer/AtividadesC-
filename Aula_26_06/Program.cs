namespace Aula_26_06;

class Program
{
    static void Main(string[] args)
    {
        ex02();
            
    }

    static void ex02()
    {
        string usuario = "";
        string senha ="";

        while (true)
        {
            Console.WriteLine("Digite seu usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();
            
            if(usuario != senha) break;
            else Console.WriteLine("Usuario e senha iguais, digite novamente");
        }
        
    }
}