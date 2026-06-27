using System.Text.Json;

namespace ConsoleApp1.Modelos;

internal class MusicasFavoritas
{
    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public void AdicionarMusicasPreferidas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivosJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-do-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine($"O arquivo json foi criado com sucesso. {Path.GetFullPath(nomeDoArquivo)}");
    }
}
