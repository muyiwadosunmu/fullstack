
using System.Text.Json;
using frontend.Models;

namespace frontend.services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _client;
        public HttpService(HttpClient httpClient)
        {
            _client = httpClient;
        }

        public async Task<WeatherForecast[]> FetchWeatherForecast(string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            using var response = await _client.SendAsync(request);
            var responseData = await response?.Content?.ReadAsStringAsync();
            return JsonSerializer.Deserialize<WeatherForecast[]>(responseData);
        }
    }
}