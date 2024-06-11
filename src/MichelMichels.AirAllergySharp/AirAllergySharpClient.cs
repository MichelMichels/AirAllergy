namespace MichelMichels.AirAllergyAPI;

public class AirAllergySharpClient(string baseUrl)
{
    private readonly string _baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));

    private HttpClient? _httpClient;



    private void InitializeHttpClient()
    {
        _httpClient ??= new HttpClient()
        {
            BaseAddress = new Uri(_baseUrl),
        };
    }
}
