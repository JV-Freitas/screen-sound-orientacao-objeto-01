using ScreenSound;

Banda cacifeClandestino = new Banda("Cacife Clandestino"); //criei a banda

Musica musica1 = new Musica(cacifeClandestino, "Linda e Doida"); //criei a musica
musica1.Duracao = 234; // atribui valor à duracao da musica
musica1.Disponivel = true; // atribui valor à disponivel no plano
musica1.ExibirFichaTecnica(); //chamando a funçao que mostra a ficha tecnica da musica

Musica musica2 = new Musica(cacifeClandestino, "Apenas Negócios") //criei a musica2
{
    Duracao = 345,// atribui valor à duracao da musica
    Disponivel = false, // atribui valor à disponivel no plano
};
musica2.ExibirFichaTecnica(); //chamando a funçao que mostra a ficha tecnica da musica2

Album gelato = new Album("Gelato"); // criei o album
gelato.AdicionarMusica(musica1); //adicionei musica1 ao album
gelato.AdicionarMusica(musica2); //adicionei musica2 ao album
gelato.ListarMusicas(); //listando as musicas que contem no album

cacifeClandestino.AdicionarAlbum(gelato); //adicionei o album à banda
cacifeClandestino.ExibirDiscografia(); //exibindo os albuns da banda

Console.WriteLine("\n\n ----------- PODCAST -----------");
Podcast podcast1 = new Podcast("InFamme Cast", "j0tta");

Episodio ep1 = new Episodio(1, "C# Orientado a Objetos", 85);
ep1.AdicionarConvidado("Carinha de .NET");
ep1.AdicionarConvidado("Fulaninho de microserviços");
ep1.AdicionarConvidado("Fulaninha de .NET");
//Console.WriteLine(ep1.Resumo);

Episodio ep2 = new Episodio(2, "React", 45);
ep2.AdicionarConvidado("Carinha do React");
ep2.AdicionarConvidado("Maninho do Front");
//Console.WriteLine(ep2.Resumo);

Episodio ep3 = new Episodio(4, "DevOps", 67);
ep3.AdicionarConvidado("Maninho de DevOps");
//Console.WriteLine(ep3.Resumo);

Episodio ep4 = new Episodio(3, "Mobile", 62);
ep4.AdicionarConvidado("Carinha do React Native");
ep4.AdicionarConvidado("Maninho do Ionic");
//Console.WriteLine(ep4.Resumo);

podcast1.AdicionarEpisodio(ep1);
podcast1.AdicionarEpisodio(ep2);
podcast1.AdicionarEpisodio(ep3);
podcast1.AdicionarEpisodio(ep4);
podcast1.ExibirDetalhes();
