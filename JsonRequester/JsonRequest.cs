using System.Text.Json;

namespace JsonRequester
{
    public class JsonRequest
    {
        /// <summary>
        /// Deserializes the provided url and returns it as <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type to return</typeparam>
        /// <param name="url">The url to fetch the Json from</param>
        /// <returns><typeparamref name="T"/></returns>
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

        /// <summary>
        /// Deserializes the provided url and returns it as <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type to return</typeparam>
        /// <param name="url">The url to fetch the Json from</param>
        /// <param name="ignoreCaseSensitive">If set to true, the deserialization will ignore case sensitivity.</param>
        /// <returns><typeparamref name="T"/></returns>
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

        /// <summary>
        /// Deserializes the provided url and returns it as <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type to return</typeparam>
        /// <param name="url">The url to fetch the Json from</param>
        /// <param name="apikeyHeader">The header of the key (field)</param>
        /// <param name="apikeyValue">The header of the key (value)</param>
        /// <returns><typeparamref name="T"/></returns>
        public async Task<T> GET<T>(string url, string apikeyHeader, string apikeyValue)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add(apikeyHeader, apikeyValue);
                using (var response = await client.GetAsync(url))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();

                    return (T)JsonSerializer.Deserialize<T>(apiResponse);
                        
                }
            }
        }
        /// <summary>
        /// Deserializes the provided url and returns it as <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type to return</typeparam>
        /// <param name="url">The url to fetch the Json from</param>
        /// <param name="apikeyHeader">The header of the key (field)</param>
        /// <param name="apikeyValue">The header of the key (value)</param>
        /// <param name="ignoreCaseSensitive">If set to true, the deserialization will ignore case sensitivity.</param>
        /// <returns><typeparamref name="T"/></returns>
        public async Task<T> GET<T>(string url, string apikeyHeader, string apikeyValue, bool ignoreCaseSensitive)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add(apikeyHeader, apikeyValue);
                using (var response = await client.GetAsync(url))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();

                    return (T)JsonSerializer.Deserialize<T>(apiResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = ignoreCaseSensitive });
                        
                }
            }
        }
    }
}