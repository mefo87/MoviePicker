using System.Text.Json.Serialization;

namespace MoviePicker.Classes;

public class Genero
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}
