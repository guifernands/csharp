class Podcast
{
    string Nome { get; set; }
    string Host { get; set; }
    int TotalEpisodios { get; set; }

    public Podcast (string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome} \nHost: {Host} \nTotal de episódios: {TotalEpisodios}");
    }
}