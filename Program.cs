using ConsoleApp1.Filtros;
using ConsoleApp1.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListasDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Drake");
        musicas[0].ExibirDetalhes();
        LinqFilter.MusicasEmCSustenido(musicas);

        var musicasPreferidasDoDaniel = new MusicasFavoritas("Daniel");

        //musicasPreferidasDoDaniel.AdicionarMusicasPreferidas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasPreferidas(musicas[537]);
        //musicasPreferidasDoDaniel.AdicionarMusicasPreferidas(musicas[700]);
        //musicasPreferidasDoDaniel.AdicionarMusicasPreferidas(musicas[317]);
        //musicasPreferidasDoDaniel.AdicionarMusicasPreferidas(musicas[13]);


        //var musicasPreferidasDaEmilly = new MusicasFavoritas("Emilly");

        //musicasPreferidasDaEmilly.AdicionarMusicasPreferidas(musicas[38]);
        //musicasPreferidasDaEmilly.AdicionarMusicasPreferidas(musicas[300]);
        //musicasPreferidasDaEmilly.AdicionarMusicasPreferidas(musicas[123]);
        //musicasPreferidasDaEmilly.AdicionarMusicasPreferidas(musicas[98]);
        //musicasPreferidasDaEmilly.AdicionarMusicasPreferidas(musicas[70]);

        //musicasPreferidasDaEmilly.ExibirMusicasFavoritas();

        //musicasPreferidasDaEmilly.GerarArquivosJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}