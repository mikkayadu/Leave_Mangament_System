using System.Net.Http;

namespace HR.LeaveManagement._MVC.Services.Base
{
    public partial class Client : IClient
    {
        private readonly HttpClient _httpClient;

        public Client(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public HttpClient HttpClient
        {
            get
            {
                return _httpClient;
            }
        }
    }
}
