Musica musica1 = new Musica();
musica1.Nome = "Lucid Dreams";
musica1.Artista = "Juice WRLD";
musica1.Duracao = 270;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.Nome = "Abracadavre";
musica2.Artista = "Kevin Sherwood";
musica2.Duracao = 332;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
