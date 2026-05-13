class Episodio
{

    string Titulo { get; set; }
    int DuracaoEpisodio { get; set; }
    string Resumo { get; }
    string Convidado { get; set; }

    public void AdicionarConvidados(string convidado)
    {
        Convidado = convidado;
    }
}