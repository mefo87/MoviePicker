using MoviePicker.Classes;
using MoviePicker.Interfaces;
using MoviePicker.Services;
using System.Text.RegularExpressions;

//TODO: Referenciar o movieDB no programa e na descricao do projeto no GitHub

var generoService = new GeneroService();

var listaDeGeneros = await generoService.RecuperaGenerosAsync();

//await MontarComeco();
await MontarListaGenerosAsync(listaDeGeneros);

async Task MontarComeco()
{
    Console.WriteLine("- - - - Selecionador de Filmes - - - -");
    Console.WriteLine();
    Console.WriteLine("Escolha um gênero de filme:");
    var generoEscolhido = Console.ReadLine();
    Console.WriteLine("escolha um ano:");
    var anoEscolhido = Console.ReadLine();
    var mensagemErro = ValidarAno(anoEscolhido);
    var ano = 0;

    if (mensagemErro == string.Empty)
        ano = int.Parse(anoEscolhido);


}
string ValidarAno(string? anoEscolhido)
{
    var regexNumero = new Regex("[0-9]+");

    if (string.IsNullOrWhiteSpace(anoEscolhido))
    {
        return "o ano não pode estar vazio!";
    }

    if (!regexNumero.IsMatch(anoEscolhido))
    {
        return "o ano deve ser um número!";
    }

    return string.Empty;
}
async Task MontarListaGenerosAsync(List<Genero> listaGeneros)
{
    foreach (var genero in listaGeneros)
    {
        Console.WriteLine($"{genero.Name}");
        Console.WriteLine($"{genero.Id}");
        Console.WriteLine();
    }
}

