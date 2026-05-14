class Episodio
{

    private List<string> convidados = new();
    int Ordem { get; }
    string Titulo { get; }
    int DuracaoEpisodio { get; }
    public string Resumo => $"{Ordem}. Título: {Titulo} ({DuracaoEpisodio} min) - {string.Join(", ", convidados)}";

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        DuracaoEpisodio = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}