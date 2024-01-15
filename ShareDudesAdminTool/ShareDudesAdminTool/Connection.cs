using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ShareDudesAdminTool
{
    using System;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    public class DatabaseClient
    {
        private readonly string baseUrl;

        public DatabaseClient(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public async Task<string> GetUserInformation(string condition)
        {
            return await SendRequest("getuserinformations", condition);
        }

        public async Task<string> CreateUser(string values)
        {
            return await SendRequest("createuser", values);
        }

        public async Task<string> CustomCommand(string values)
        {
            return await SendRequest("customCommand", values);
        }

        private async Task<string> SendRequest(string method, string data)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var requestUrl = $"{baseUrl}/request_database?methode={method}&values={data}";
                    var response = await client.PostAsync(requestUrl, new StringContent(string.Empty, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        return $"Error: {response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    return $"Exception: {ex.Message}";
                }
            }
        }
    }

}
