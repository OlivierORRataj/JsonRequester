using System.Text.Json;

namespace JsonRequester
{
    /// <summary>
    /// Accepts application/json APIs
    /// </summary>
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
        /// <param name="options">Options to be set for the Serializer</param>
        /// <returns><typeparamref name="T"/></returns>
        public async Task<T> GET<T>(string url, JsonSerializerOptions options)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                using (var response = await client.GetAsync(url))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();

                    return (T)JsonSerializer.Deserialize<T>(apiResponse, options);
                        
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
        /// <param name="options">Options to be set for the Serializer</param>
        /// <returns><typeparamref name="T"/></returns>
        public async Task<T> GET<T>(string url, string apikeyHeader, string apikeyValue, JsonSerializerOptions options)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add(apikeyHeader, apikeyValue);
                using (var response = await client.GetAsync(url))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();

                    return (T)JsonSerializer.Deserialize<T>(apiResponse, options);
                        
                }
            }
        }
    }
}