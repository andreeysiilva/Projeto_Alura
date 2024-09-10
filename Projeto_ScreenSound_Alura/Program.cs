Episodio ep1 = new(1,"Episodio 1", 300);
ep1.AdicionarConvidados("João");
ep1.AdicionarConvidados("Maria");
Console.WriteLine(ep1.Resumo);

Podcast naNuvem = new("Na Nuvem", "Andrey Silva");
naNuvem.AdicionarEpisodio(ep1);
naNuvem.ExibirDetalhes();
