using MoviePicker.Classes;

namespace MoviePicker.Interfaces;

public interface IGeneroService
{
    Task<List<Genero>> RecuperaGenerosAsync();
}
