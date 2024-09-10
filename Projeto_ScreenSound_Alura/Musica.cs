
class Musica
{
    // CRIADO COM ATRIBUTOS E CONSTRUTOR
    public Musica(Banda artista, string nome)
    {   
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    // CRIADO COMO LABDA => mais a informação que deseja aplicar!
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome da Música: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Plano: Plus+ Ativo.");
        }else
        {
            Console.WriteLine("Plano: Adquira o plano Plus+");
        }
    }
}
