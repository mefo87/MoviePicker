using System.Net.Http.Headers;

namespace MoviePicker.Builders;

public class HttpClientBuilder
{
    private const string Key = "17d16f881195f916c0f4412c2a63302f";
    private const string Token = "eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIxN2QxNmY4ODExOTVmOTE2YzBmNDQxMmMyYTYzMzAyZiIsInN1YiI6IjY1NjEzYTc2MjQ0MTgyMDBjYTc2OTQyYyIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.KGuEFb8RxxpKyu3XJNt3Vmve1N-Jn6bPNvv6W_lF05o";
    private const string ApiUrl = "https://api.themoviedb.org/3/";

    private HttpClient _httpClient = new();

    public HttpClient GetClient()
    {
        SetupHttpClient();
        return _httpClient;
    }

    public void SetupHttpClient()
    {
        _httpClient.BaseAddress = new Uri(ApiUrl);
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
}