using Letter.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Letter.Services
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

        public async Task AddAulaAsync(String version)
        {
            string url = "https://api.github.com/repos/jonasmapuche/c-sharp-letter/releases";
            Uri uri = new Uri(string.Format(url));
            var token = "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";
            Versao versao = new Versao(version);
            var data = JsonConvert.SerializeObject(versao);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            client.DefaultRequestHeaders.Add("X-Auth-Token", token);
            response = await client.PostAsync(uri, content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro ao incluir produto");
            }
        }
    }
}
