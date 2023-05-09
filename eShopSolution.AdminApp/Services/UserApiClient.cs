using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;

namespace eShopSolution.AdminApp.Services
{
    public class UserApiClient : IUserApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        public UserApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
           
        }
        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8,"application/json");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.PostAsync("/api/users/authenticate", httpContent);
            var token = await response.Content.ReadAsStringAsync();
            return token;
        }

        public async Task<PagedResult<UserVm>> GetUsersPagings(GetUserPagingRequest request)
        {

            
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", request.BearerToken);

            Dictionary<string, string> Params = new Dictionary<string, string>();
            Params.Add( "Keyword", request.Keyword );
            Params.Add("PageIndex", request.PageIndex + string.Empty);
            Params.Add("PageSize", request.PageSize + string.Empty);
            var content = new FormUrlEncodedContent(Params);           
            var response = await client.PostAsync($"/api/users/paging", content);


            /////// http://localhost/api/users/paging?pageIndex=1&pageSize=10&keyword=
            ///
            //var response = await client.GetAsync("/api/users/paging?pageIndex=1&pageSize=10&keyword");


            //var response = await client.GetAsync("/api/users/testpaging");

            //var response = await client.GetAsync("/api/users/testpag");
            var body = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<PagedResult<UserVm>>(body);
            return users;
        }

        public async Task<bool> RegisterUser(RegisterRequest registerRequest)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            var json = JsonConvert.SerializeObject(registerRequest);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"/api/users", httpContent);
            return response.IsSuccessStatusCode;
        }
    }
}
