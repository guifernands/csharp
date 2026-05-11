Banda linkinpark = new Banda();
linkinpark.Nome = "Linkin Park";

Album albumLIVINGTHINGS = new Album();
albumLIVINGTHINGS.Nome = "LIVING THINGS";

Musica musica1 = new Musica(linkinpark);
musica1.Nome = "LOST IN THE ECHO";
musica1.Duracao = 185;

Musica musica2 = new Musica(linkinpark);
musica2.Nome = "ROADS UNTRAVELED";
musica2.Duracao = 230;

Musica musica3 = new Musica(linkinpark);
musica3.Nome = "CASTLE OF GLASS";
musica3.Duracao = 205;

Musica musica4 = new Musica(linkinpark);
musica4.Nome = "BURN IT DOWN";
musica4.Duracao = 230;


albumLIVINGTHINGS.AdicionarMusica(musica1);
albumLIVINGTHINGS.AdicionarMusica(musica2);
albumLIVINGTHINGS.AdicionarMusica(musica3);
albumLIVINGTHINGS.AdicionarMusica(musica4);


linkinpark.AdicionarAlbum(albumLIVINGTHINGS);
linkinpark.ExibirDiscografia();