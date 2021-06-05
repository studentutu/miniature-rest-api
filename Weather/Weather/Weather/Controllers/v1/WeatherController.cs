using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weather.Contracts;

namespace Weather.Controllers
{
    public class WeatherController : Controller
    {
        private string ApiKey = "4NxMT50UP2WXalLU4bmkNhNo2CGHDjNcEbcp6osQ";
        private string AccessId = "0wLetMQrQMHTp3cJYINA6";

        [HttpGet(ApiRoutes.Weather.Get + "/{location}")]
        public async Task<IActionResult> GetWeather(string location)
        {
            var client = new HttpClient();
            var uri = new Uri(
                $"https://api.aerisapi.com/forecasts/{location}?client_id={AccessId}&client_secret={ApiKey}");

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri,
            };
            var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return Ok(body);
            }

            return Problem(response.Content.ToString(), null, (int) response.StatusCode);
        }
    }
}