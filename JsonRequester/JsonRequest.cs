using System.Text.Json;

namespace JsonRequester
{
    public class JsonRequest
    {
        public async Task<T> GET<T>(string url)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                using (var response = await client.GetAsync(url))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();

                    return (T)JsonSerializer.Deserialize<T>(apiResponse);
                        
                }
            }
        }

        public async Task<T> GET<T>(string url, bool ignoreCaseSensitive)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                using (var response = await client.GetAsync(url))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();

                    return (T)JsonSerializer.Deserialize<T>(apiResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = ignoreCaseSensitive });
                        
                }
            }
        }

        public async Task<T> GET<T>(string url, string apikeyHeader, string apikey)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add(apikeyHeader, apikey);
                using (var response = await client.GetAsync(url))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();

                    return (T)JsonSerializer.Deserialize<T>(apiResponse);
                        
                }
            }
        }

        public async Task<T> GET<T>(string url, string apikeyHeader, string apikey, bool ignoreCaseSensitive)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add(apikeyHeader, apikey);
                using (var response = await client.GetAsync(url))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();

                    return (T)JsonSerializer.Deserialize<T>(apiResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = ignoreCaseSensitive });
                        
                }
            }
        }
    }
}