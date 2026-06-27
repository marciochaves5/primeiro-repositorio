using ConsoleApp1.Modelos;
using System.Threading.Channels;

namespace ConsoleApp1.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistaPorGeneroMusical =
            musicas.Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine("Artistas filtrado por gênero: ");
        foreach (var artista in artistaPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista =
            musicas.Where(musica => musica.Artista.Equals(nomeDoArtista))
            .Select(musica => musica.Nome)
            .Distinct()
            .ToList();
        Console.WriteLine($"Músicas do artista {nomeDoArtista}");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }
    
    public static void MusicasEmCSustenido(List<Musica> musicas)
    {
        var musicasEmCSharp =
            musicas.Where(t => t.Tonalidade == "C#").ToList();
        Console.WriteLine($"Músicas em C#: ");
        foreach ( var musica in musicasEmCSharp )
        {
            Console.WriteLine(musica.Nome);
        }
    }
}
