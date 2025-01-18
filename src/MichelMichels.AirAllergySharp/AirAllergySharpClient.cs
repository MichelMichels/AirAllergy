using MichelMichels.AirAllergySharp.Models;
using System.Diagnostics;
using System.Net.Http.Json;

namespace MichelMichels.AirAllergySharp;

public class AirAllergySharpClient(AirAllergyOptions options) : IAirAllergySharpClient
{
    private readonly AirAllergyOptions _options = options ?? throw new ArgumentNullException(nameof(options));

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
    public async Task<List<StationReading>> GetStationReadings(string? station = null, string? allergen = null)
    {
        InitializeHttpClient();

        string requestUri = "Measure";

        if (!string.IsNullOrEmpty(station) || !string.IsNullOrEmpty(allergen))
        {
            requestUri += "?";
        }

        if (!string.IsNullOrEmpty(station))
        {
            requestUri += $"station={station}";

            if (!string.IsNullOrEmpty(allergen))
            {
                requestUri += "&";
            }
        }

        if (!string.IsNullOrEmpty(allergen))
        {
            requestUri += $"allergen={allergen}";
        }

        Debug.WriteLine(requestUri);
        HttpResponseMessage response = await _httpClient!.GetAsync(requestUri);

        return await ParseContent<List<StationReading>>(response);
    }

    private void InitializeHttpClient()
    {
        _httpClient ??= new HttpClient()
        {
            BaseAddress = new Uri(_options.BaseUrl),
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
