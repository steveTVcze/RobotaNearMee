using RobotaNearMe.Lib.Modelos;
using RobotaNearMe.Lib;
using System.Net.Http;

namespace RobotaNearMe.Client.Services
{
    public class ApiService
    {
        static readonly HttpClient _httpClient = new HttpClient();
        public IEnumerable<JobOffer> GetOffers()
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {

                var offers = _httpClient.GetFromJsonAsync<IEnumerable<JobOffer>>(Endpoints.V1.GETOFFERS).Result;
                return offers;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return new List<JobOffer>();
            }
        }
        public IEnumerable<JobField> GetJobFields()
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {

                var fields = _httpClient.GetFromJsonAsync<IEnumerable<JobField>>(Endpoints.V1.GETJOBFIELDS).Result;
                return fields;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return new List<JobField>();
            }
        }
        public IEnumerable<User> GetUsers()
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {

                var users = _httpClient.GetFromJsonAsync<IEnumerable<User>>(Endpoints.V1.GETUSERS).Result;
                return users;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return new List<User>();
            }
        }
    }
}
