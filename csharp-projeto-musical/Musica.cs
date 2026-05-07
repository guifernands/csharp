using System.Dynamic;

class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool Disponivel { get; set; }

    public void EscreveDisponivel(bool value)
    {
        Disponivel = value;
    }

    public bool LeDisponivel()
    {
        return Disponivel;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}