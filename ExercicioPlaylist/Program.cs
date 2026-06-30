namespace ExercicioPlaylist;

class Program
{
    static List<String> Playlist = new List<String>();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("**** Menu PlayList ****");
            Console.WriteLine("[1] Adicionar Musica \n[2] Listar Playlist \n[3] Remover Musica \n[4] Buscar música");
            Console.WriteLine("[5] Mostrar Quantidade de música \n[6] Tocar Música Aleatoria \n[7] Limpar Playlist");
            Console.WriteLine("[0] Sair");
            int menu = int.Parse(Console.ReadLine());
            if (menu == 0) break;

            switch (menu)
            {
                case 1: AdicionarMusica(); break;
                case 2: ListarPlaylist(); break;
                case 3: RemoverMusica(); break;
                case 4: BuscarMusica(); break;
                case 5: QtdMusica(); break;
                case 6: MusicaAleatoria(); break;
                case 7: Console.WriteLine("Exemplo7"); break;
                default: break;
            }
        }
    }

    static void AdicionarMusica()
    {
        Console.Clear();
        Console.WriteLine("*** Adicionar Musica ***");
        Console.Write("Nome da Música: ");
        Playlist.Add(Console.ReadLine().ToUpper());
    }

    static void ListarPlaylist()
    {
        Console.Clear();
        Console.WriteLine("*** Lista da Playlist ***");
        for (var i = 0; i < Playlist.Count; i++)
        {
            Console.WriteLine(Playlist[i]);
        }
    }

    static void RemoverMusica()
    {
        Console.Clear();
        Console.WriteLine("*** Remover Musica ***");
        Console.Write("Nome da Musica: ");
        string musica = Console.ReadLine().ToUpper();
        if (Playlist.Contains(musica)) Playlist.Remove(musica);
        else Console.WriteLine("Musica não encontrada");
    }

    static void BuscarMusica()
    {
        Console.Clear();
        Console.WriteLine("*** Buscar Musica ***");
        Console.Write("Nome da Musica: ");
        string musica = Console.ReadLine().ToUpper();
        if (Playlist.Contains(musica)) Console.WriteLine("Música Encontrada!!!");
        else Console.WriteLine("Musica não encontrada");
    }

    static void QtdMusica()
    {
        Console.Clear();
        Console.WriteLine("*** Qtd Musica ***");
        int qtd_musica = 0;
        for (var i = 0; i < Playlist.Count; i++)
        {
            qtd_musica++;
        }

        Console.WriteLine($"Essa Playlist tem {qtd_musica} musicas");
    }

    static void MusicaAleatoria()
    {
        Console.Clear();
        Console.WriteLine("*** Musica Aleatoria ***");
        Console.Write($"Tocando agora: {Playlist}");
    }

    static void LimparPlaylist()
    {
        Console.Clear();
        Console.WriteLine("*** Playlist Limpada!!! ***");
        Playlist.RemoveAll(x => x == "");
    }
}