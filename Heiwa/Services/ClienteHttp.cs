using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Heiwa
{
    public class ClienteHttp
    {
        private static HttpClient _client;
        private static readonly string BaseUrl = "https://localhost:7009/api/";

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
        public static async Task<HttpResponseMessage> GetAsync(string relativeUrl)
        {
            HttpClient client = CreateHttpClient();
            // Puedes pasar directamente la ruta relativa, no es necesario concatenar con BaseUrl
            return await client.GetAsync(relativeUrl);
        }

        // Método para hacer una solicitud POST con baseUrl
        public static async Task<HttpResponseMessage> PostAsync(string relativeUrl, HttpContent content)
        {
            HttpClient client = CreateHttpClient();
            // Puedes pasar directamente la ruta relativa, no es necesario concatenar con BaseUrl
            return await client.PostAsync(relativeUrl, content);
        }

        public static async Task<HttpResponseMessage> PutAsync(string relativeUrl, HttpContent content)
        {
            HttpClient client = CreateHttpClient();
            // Puedes pasar directamente la ruta relativa, no es necesario concatenar con BaseUrl
            return await client.PutAsync(relativeUrl, content);
        }

        public static async Task<HttpResponseMessage> DeleteAsync(string relativeUrl)
        {
            HttpClient client = CreateHttpClient();
            return await client.DeleteAsync(relativeUrl);
        }
    }
}
