class Episodio
{
    private readonly List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"Ordem: {Ordem} \nTitulo: {Titulo} \nDuração: {Duracao} min" +
        $"\nConvidados: {string.Join(", ", convidados)}";
    // O método string.Join em C# é usado para concatenar os elementos de uma coleção (como um array ou uma lista) em uma única string, inserindo um separador entre os elementos.
    // Ele é útil quando você deseja criar uma string a partir de uma coleção de valores com um delimitador, como uma vírgula, espaço ou qualquer outro caractere.

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}