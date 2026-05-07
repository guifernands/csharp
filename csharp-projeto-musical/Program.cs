Musica musica1 = new Musica();
musica1.nome = "Lucid Dreams";
musica1.artista = "Juice WRLD";
musica1.duracao = 270;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.nome = "Abracadavre";
musica2.artista = "Kevin Sherwood";
musica2.duracao = 332;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
