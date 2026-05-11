using System.Dynamic;

class Musica
{
    public Musica(Banda artista)
    {
        Artista = artista;
    }
    public string Nome { get; set; } = string.Empty; /* operaçao de leitura (get) e escrita (set) */
    public Banda Artista { get; } 
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } /* propriedades usam PascalCase */


    /* essa propriedade apenas lê, e nao tem a escrita, logo, não pode ser reescrita */
    /* public string DescricaoResumida 
    { 
        get
        {
            return $"A música {Nome} pertence a {Artista}.";
        }
    } */
    /* OU */

    /* arrow function / lambda */
    public string DescricaoResumida => 
        $"A música {Nome} pertence à {Artista}.";

    public void EscreveDisponivel(bool value)
    {
        Disponivel = value;
    }

    public void ExibirFichaTecnica()
    {   
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Descrição: {DescricaoResumida}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}