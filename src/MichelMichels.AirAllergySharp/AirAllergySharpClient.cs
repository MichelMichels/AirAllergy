using MichelMichels.AirAllergySharp.Models;
using System.Diagnostics;
using System.Net.Http.Json;

namespace MichelMichels.AirAllergySharp;

public class AirAllergySharpClient(string baseUrl) : IAirAllergySharpClient
{
    private readonly string _baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));

    private HttpClient? _httpClient;

    public async Task<List<Permission>> GetPermissions()
    {
        InitializeHttpClient();

        string requestUri = "Permission";
        HttpResponseMessage response = await _httpClient!.GetAsync(requestUri);
        return await ParseContent<List<Permission>>(response);
    }
    public async Task<List<Station>> GetStations()
    {
        InitializeHttpClient();

        string requestUri = "Station";
        HttpResponseMessage response = await _httpClient!.GetAsync(requestUri);

        return await ParseContent<List<Station>>(response);
    }
    public async Task<List<Allergen>> GetAllergens()
    {
        InitializeHttpClient();

        string requestUri = "Allergen";
        HttpResponseMessage response = await _httpClient!.GetAsync(requestUri);

        return await ParseContent<List<Allergen>>(response);
    }

    private void InitializeHttpClient()
    {
        _httpClient ??= new HttpClient()
        {
            BaseAddress = new Uri(_baseUrl),
        };
    }
    private static async Task<T> ParseContent<T>(HttpResponseMessage message) where T : class
    {
        try
        {
            if (message.IsSuccessStatusCode)
            {
                T result = await message.Content.ReadFromJsonAsync<T>() ?? throw new NotSupportedException("Serialized result was null.");
                return result;
            }
            else
            {
                throw new NotSupportedException();
            }
        }
        catch (Exception)
        {
            Debug.WriteLine(await message.Content.ReadAsStringAsync());

            throw;
        }
    }
}
