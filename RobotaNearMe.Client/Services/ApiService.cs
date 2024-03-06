using RobotaNearMe.Lib.Modelos;
using RobotaNearMe.Lib;
using System.Net.Http;
using System.Net.Http.Json;

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
        public IEnumerable<OfferInUser> GetOffersInUsers(Guid OfferId)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {

                var offers = _httpClient.GetFromJsonAsync<IEnumerable<OfferInUser>>(Endpoints.V1.GETOFFERSINUSER + $"/{OfferId}").Result;
                return offers;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return new List<OfferInUser>();
            }
        }
        public IEnumerable<string> GetOffersInUsersForCompany(Guid companyId)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {

                var offers = _httpClient.GetFromJsonAsync<IEnumerable<string>>(Endpoints.V1.GETOFFERINUSERFORCOMPANY + $"/{companyId}").Result;
                return offers;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return new List<string>();
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
        public User GetUserByName(string username)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {

                var users = _httpClient.GetFromJsonAsync<User>(Endpoints.V1.GETUSERBYNAME + $"/{username}").Result;
                return users;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return new User();
            }
        }
        public CompanyReal GetCompanyById(Guid userId)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {

                var users = _httpClient.GetFromJsonAsync<CompanyReal>(Endpoints.V1.GETCOMPANY + $"/{userId}").Result;
                return users;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return new CompanyReal();
            }
        }
        public FileTable GetFileForUser(Guid userId)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {

                var users = _httpClient.GetFromJsonAsync<FileTable>(Endpoints.V1.GETFILEFORUSER + $"/{userId}").Result;
                return users;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return new FileTable();
            }
        }
        public CompanyReal GetCompanyByCompanyId(Guid companyId)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {

                var users = _httpClient.GetFromJsonAsync<CompanyReal>(Endpoints.V1.GETCOMPANYBYCOMPANYID + $"/{companyId}").Result;
                return users;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return new CompanyReal();
            }
        }
        public bool PostUser(User model)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {
                var user = _httpClient.PostAsJsonAsync<User>(Endpoints.V1.POSTUSER, model).Result;
                return true;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return false;
            }
        }
        public bool PutFileForUser(FileTable modelos)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {
                var user = _httpClient.PutAsJsonAsync<FileTable>(Endpoints.V1.PUTFILE, modelos).Result;
                return true;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return false;
            }
        }
        public bool PutJobOffer(JobOffer modelos)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {
                var user = _httpClient.PutAsJsonAsync<JobOffer>(Endpoints.V1.PUTJOBOFFER, modelos).Result;
                return true;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return false;
            }
        }
        public bool PutUserProfile(User modelos)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {
                var user = _httpClient.PutAsJsonAsync<User>(Endpoints.V1.PUTUSERPROFILE, modelos).Result;
                return true;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return false;
            }
        }
        public bool PutCompanyProfile(CompanyReal model)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {
                var user = _httpClient.PutAsJsonAsync<CompanyReal>(Endpoints.V1.PUTCOMPANYPROFILE, model).Result;
                return true;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return false;
            }
        }
        public bool PostFile(FileTable model)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {
                var user = _httpClient.PostAsJsonAsync<FileTable>(Endpoints.V1.POSTFILE, model).Result;
                return true;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return false;
            }
        }
        public bool PostJobOffer(JobOffer model)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {
                var user = _httpClient.PostAsJsonAsync<JobOffer>(Endpoints.V1.POSTJOBOFFER, model).Result;
                return true;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return false;
            }
        }
        public bool PostOfferInUser(OfferInUser model)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {
                var user = _httpClient.PostAsJsonAsync<OfferInUser>(Endpoints.V1.POSTOFFERINUSER, model).Result;
                return true;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return false;
            }
        }
        public bool PostCompany(CompanyReal model)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {
                var user = _httpClient.PostAsJsonAsync<CompanyReal>(Endpoints.V1.POSTCOMPANY, model).Result;
                return true;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return false;
            }
        }
        public bool PostCompanyContact(ContactCompany model)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {
                var user = _httpClient.PostAsJsonAsync<ContactCompany>(Endpoints.V1.POSTCOMPANYCONTACT, model).Result;
                return true;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return false;
            }
        }
        public bool PostContact(Contact model)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {
                var user = _httpClient.PostAsJsonAsync<Contact>(Endpoints.V1.POSTCONTACT, model).Result;
                return true;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return false;
            }
        }
        public bool PostEdu(Education model)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7159/");
            }
            try
            {
                var user = _httpClient.PostAsJsonAsync<Education>(Endpoints.V1.POSTEDU, model).Result;
                return true;
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Something went wrong: {exception.Message}");
                return false;
            }
        }
    }
}
