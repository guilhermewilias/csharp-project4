
using System.Text.Json.Serialization;

namespace api_project.modelos;

internal class musica
{
    [JsonPropertyName("song")]
    public string? Nome {  get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? genero { get; set; }

    public void detalhesMusica()
    {
        Console.WriteLine($"Artista : {Artista}");
        Console.WriteLine($"Musica : {Nome}");
        Console.WriteLine($"Duração : {duracao/1000}");
        Console.WriteLine($"Gênero musical : {genero}");
    }
}
