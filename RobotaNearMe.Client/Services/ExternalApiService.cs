using RobotaNearMe.Client.Models;

namespace RobotaNearMe.Client.Services
{
    public class ExternalApiService
    {
        private readonly HttpClient _client;
        private readonly ILogger<ExternalApiService> _logger;

        public ExternalApiService(ILogger<ExternalApiService> logger)
        {
            _client = new HttpClient();
            _logger = logger;
        }

        private const string API_V1 = "https://stoic.tekloon.net/stoic-quote";
        private const string API_V2 = "https://randomfox.ca/floof/";
        private const string API_V3 = "https://random.dog/woof.json";
        public async Task<ApiModel.Rootobject> GetQuote()
        {
            var data = await Download<ApiModel.Rootobject>($"{API_V1}");
            return data;
        }
        public async Task<ApiCatModel.Rootobject> GetFox()
        {

            var data = await Download<ApiCatModel.Rootobject>($"{API_V2}");
            return data;
        }
        public async Task<ApiDogModel.Rootobject> GetDoggo()
        {

            var data = await Download<ApiDogModel.Rootobject>($"{API_V3}");
            return data;
        }
        private async Task<T?> Download<T>(string url)
        {
            try
            {
                return await _client.GetFromJsonAsync<T>(url);
            }
            catch (Exception exc)
            {
                _logger.LogError($"{url} - {exc.Message}}}");
            }

            return default(T?);
        }
    }
}
