using Letter.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Letter.WebAPI.Services
{
    public class VersionService
    {
        HttpClient client = new HttpClient();

        public async Task<GitUser> GetVersionAsync()
        {
            string url = "https://api.github.com/users/jonasmapuche";
            var response = await client.GetStringAsync(url);
            var git = JsonConvert.DeserializeObject<GitUser>(response);
            return git;
        }
    }
}
