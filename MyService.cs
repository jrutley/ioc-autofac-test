using System.Net.Http;
using System.Threading.Tasks;

namespace iocTest
{
    public interface IMyService
    {
        Task<string> CallAPage();
    }

    public class MyService : IMyService
    {
        private HttpClient httpClient;
        private OtherService urlService;

        public MyService(HttpClient httpClient, OtherService urlService)
        {
            this.httpClient = httpClient;
            this.urlService = urlService;
        }

        public async Task<string> CallAPage()
        {
            var response = await httpClient.GetAsync(urlService.Address);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
