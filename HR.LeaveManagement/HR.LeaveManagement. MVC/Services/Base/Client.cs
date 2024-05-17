using System.Net.Http;
using HR.LeaveManagement.MVC.Services;


namespace HR.LeaveManagement.MVC.Services.Base


{
    public partial class Client:IClient
    { 
        public HttpClient HttpClient
        {
            get
            {
                return _httpClient;
            }
        }
    }
}
