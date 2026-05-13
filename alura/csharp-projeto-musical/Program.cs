Banda linkinpark = new Banda("Linkin Park");

Album albumLIVINGTHINGS = new Album("LIVING THINGS");

Musica musica1 = new Musica(linkinpark, "LOST IN THE ECHO")
{
    Duracao = 185,
    Disponivel = true
};

Musica musica2 = new Musica(linkinpark, "ROADS UNTRAVELED")
{
    Duracao = 230,
    Disponivel = false
};

Musica musica3 = new Musica(linkinpark, "CASTLE OF GLASS")
{
    Duracao = 205,
    Disponivel = true
};

albumLIVINGTHINGS.AdicionarMusica(musica1);
albumLIVINGTHINGS.AdicionarMusica(musica2);
albumLIVINGTHINGS.AdicionarMusica(musica3);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
linkinpark.AdicionarAlbum(albumLIVINGTHINGS);
linkinpark.ExibirDiscografia();