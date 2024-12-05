using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Heiwa
{
    public class ClienteHttp
    {
        private static HttpClient _client;
        private static readonly string BaseUrl = "http://localhost:5027/api/";

        public static HttpClient CreateHttpClient()
        {
            if (_client == null)
            { 

                // Establecer la URL base para las solicitudes
                _client = new HttpClient()
                {
                    BaseAddress = new Uri(BaseUrl)
                };

                // Establecer encabezados globales
                _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                _client.DefaultRequestHeaders.Add("User-Agent", "CustomHttpClientApp/1.0");
            }
            return _client;
        }

        // Método para hacer una solicitud GET con baseUrl
        public static async Task<string> GetAsync(string relativeUrl)
        {
            HttpClient client = CreateHttpClient();
            // Puedes pasar directamente la ruta relativa, no es necesario concatenar con BaseUrl
            HttpResponseMessage response = await client.GetAsync(relativeUrl);
            response.EnsureSuccessStatusCode(); // Lanza una excepción si la respuesta no es exitosa
            return await response.Content.ReadAsStringAsync();
        }

        // Método para hacer una solicitud POST con baseUrl
        public static async Task<string> PostAsync(string relativeUrl, HttpContent content)
        {
            HttpClient client = CreateHttpClient();
            // Puedes pasar directamente la ruta relativa, no es necesario concatenar con BaseUrl
            HttpResponseMessage response = await client.PostAsync(relativeUrl, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> PutAsync(string relativeUrl, HttpContent content)
        {
            HttpClient client = CreateHttpClient();
            // Puedes pasar directamente la ruta relativa, no es necesario concatenar con BaseUrl
            HttpResponseMessage response = await client.PutAsync(relativeUrl, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> DeleteAsync(string relativeUrl)
        {
            HttpClient client = CreateHttpClient();
            HttpResponseMessage response = await client.DeleteAsync(relativeUrl);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
