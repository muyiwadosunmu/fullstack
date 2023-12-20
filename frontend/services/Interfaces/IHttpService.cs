
using frontend.Models;

namespace frontend.services
{
    public interface IHttpService
    {
        Task<WeatherForecast[]> FetchWeatherForecast(string endpoint);
    }
}