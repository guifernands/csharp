class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    
    public void ExibirAlbum()
    {   
        Console.WriteLine($"Lista de músicas do álbum {Nome}:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Esse álbum possui a duração total de {DuracaoTotal} segundos.");

    }
}