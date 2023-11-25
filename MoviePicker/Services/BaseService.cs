using MoviePicker.Builders;

namespace MoviePicker.Services;

public abstract class BaseService
{
    protected HttpClient _httpClient { get; set; } = new HttpClientBuilder().GetClient();
}
