using MoviePicker.Classes;

namespace MoviePicker.Interfaces;

public interface IFilmeService
{
    Task<List<Filme>> RecuperaFilmesAsync();
    Task<List<Filme>> RecuperaFilmesPorGeneroAsync(int idGenero);
    Task<List<Filme>> RecuperaFilmesPorGeneroEAnoAsync(int idGenero, int ano);
    Task<List<Filme>> RecuperaFilmesPorPessoaAsync(int idPessoa);
    Task<List<Filme>> RecuperaFilmesOrdenadosPorPopularidade();
    Task<List<Filme>> RecuperaFilmesPorAno(int ano);
}
