Album albumLifetime = new Album();
albumLifetime.Nome = "Lifetime";

Musica musica1 = new Musica();
musica1.Nome = "Seasons";
musica1.Duracao = 129;

Musica musica2 = new Musica();
musica2.Nome = "The Chase";
musica2.Duracao = 142;

Musica musica3 = new Musica();
musica3.Nome = "The Garden";
musica3.Duracao = 182;

Musica musica4 = new Musica();
musica4.Nome = "Lifetime";
musica4.Duracao = 184;


albumLifetime.AdicionarMusica(musica1);
albumLifetime.AdicionarMusica(musica2);
albumLifetime.AdicionarMusica(musica3);
albumLifetime.AdicionarMusica(musica4);

albumLifetime.ExibirAlbum();