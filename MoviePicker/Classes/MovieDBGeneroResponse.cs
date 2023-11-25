using System.Text.Json.Serialization;

namespace MoviePicker.Classes;

public class MovieDBGeneroResponse
{
    [JsonPropertyName("genders")]
    public List<Genero> Genres { get; set; }
}
