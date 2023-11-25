using MoviePicker.Classes;
using MoviePicker.Interfaces;
using Newtonsoft.Json;

namespace MoviePicker.Services;

public class GeneroService : BaseService, IGeneroService
{
    public async Task<List<Genero>> RecuperaGenerosAsync()
    {
        var json = await _httpClient.GetStringAsync("genre/movie/list?language=pt");

        if (string.IsNullOrWhiteSpace(json))
            return new List<Genero>();

        var movieDBGeneroResponse = JsonConvert.DeserializeObject<MovieDBGeneroResponse>(json);

        if (movieDBGeneroResponse == null)
            return new List<Genero>();

        return movieDBGeneroResponse.Genres;
    }
}
