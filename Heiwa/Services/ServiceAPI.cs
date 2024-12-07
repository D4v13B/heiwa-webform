namespace Heiwa.Services
{
    using Heiwa.Models;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    public class ServiceAPI
    {

        //Usuarios

        //Agregar usuario
        public static async Task SaveUsuarioAsync(UsuarioRequest usuarioRequest)
        {
            
            var url = "Usuario";

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(usuarioRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateUsuarioAsync(UsuarioRequest usuarioRequest, int id)
        {
            var url = $"Usuario/{id}";

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(usuarioRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteUsuarioAsync(int id)
        {
            var url = $"Usuario/{id}";

            HttpResponseMessage response = await ClienteHttp.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
        }

        public static async Task<List<Usuario>> GetUsuarios()
        {
            var url = "Usuario";

            HttpResponseMessage response = await ClienteHttp.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            // Deserializar el JSON
            var usuarios = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Usuario>>(responseBody);

            // Asignar el nombre de UsuarioTipo a una propiedad adicional si es necesario
            foreach (var usuario in usuarios)
            {
                string tipoNombre = usuario.UsuarioTipo.Tipo ?? "Sin Tipo"; // Manejar valores 
            }

            return usuarios;
        }


        //Ingredientes
        public static async Task<List<Ingrediente>> GetIngredientesAsync()
        {
            
            var url = "Ingrediente"; 

            HttpResponseMessage response = await ClienteHttp.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Ingrediente>>(responseBody);
        }

        // Obtener un ingrediente por su ID
        public static async Task<Ingrediente> GetIngredienteByIdAsync(int id)
        {
            
            var url = $"Ingrediente/{id}"; 

            HttpResponseMessage response = await ClienteHttp.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Ingrediente>(responseBody);
        }

        // Guardar un nuevo ingrediente
        public static async Task SaveIngredienteAsync(IngredienteRequest ingredienteRequest)
        {
           
            var url = "Ingrediente"; 

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(ingredienteRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

        }

        // Actualizar un ingrediente
        public static async Task UpdateIngredienteAsync(int id, IngredienteRequest ingredienteRequest)
        {
            
            var url = $"Ingrediente/{id}"; 

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(ingredienteRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PutAsync(url, content);
            response.EnsureSuccessStatusCode();

        }

        // Eliminar un ingrediente
        public static async Task DeleteIngredienteAsync(int id)
        {
            
            var url = $"Ingrediente/{id}"; 

            HttpResponseMessage response = await ClienteHttp.DeleteAsync(url);
            response.EnsureSuccessStatusCode();

        }

        //Productos
        public static async Task<List<Producto>> GetProductsAsync()
        {

            var url = "Producto"; 

            HttpResponseMessage response = await ClienteHttp.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Producto>>(responseBody);
        }

        // Obtener un producto por su ID
        public static async Task<Producto> GetProductByIdAsync(int id)
        {

            var url = $"Producto/{id}"; 

            HttpResponseMessage response = await ClienteHttp.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Producto>(responseBody);
        }

        // Guardar un nuevo producto
        public static async Task SaveProductAsync(ProductoRequest productoRequest)
        {

            var url = "Producto"; 

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(productoRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

        }

        // Actualizar un producto
        public static async Task UpdateProductAsync(int id, ProductoRequest productoRequest)
        {

            var url = $"Producto/{id}"; 

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(productoRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PutAsync(url, content);
            response.EnsureSuccessStatusCode();

            Console.WriteLine("Producto actualizado exitosamente.");
        }

        // Eliminar un producto
        public static async Task DeleteProductAsync(int id)
        {

            var url = $"Producto/{id}"; 

            HttpResponseMessage response = await ClienteHttp.DeleteAsync(url);
            response.EnsureSuccessStatusCode();

            Console.WriteLine("Producto eliminado exitosamente.");
        }

        //Metodo de pago
        // Obtener todos los métodos de pago
        public static async Task<List<MetodoPago>> GetMetodosPagoAsync()
        {

            var url = "MetodoPago"; 

            HttpResponseMessage response = await ClienteHttp.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();


            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<MetodoPago>>(responseBody);
        }

        // Obtener un método de pago por su ID
        public static async Task<MetodoPago> GetMetodoPagoByIdAsync(int id)
        {

            var url = $"MetodoPago/{id}"; 

            HttpResponseMessage response = await ClienteHttp.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return Newtonsoft.Json.JsonConvert.DeserializeObject<MetodoPago>(responseBody);
        }

        // Guardar un nuevo método de pago
        public static async Task SaveMetodoPagoAsync(MetodoPagoRequest metodoPagoRequest)
        {

            var url = "MetodoPago"; 

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(metodoPagoRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            Console.WriteLine("Método de pago guardado exitosamente.");
        }

        // Actualizar un método de pago
        public static async Task UpdateMetodoPagoAsync(int id, MetodoPagoRequest metodoPagoRequest)
        {

            var url = $"MetodoPago/{id}"; 

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(metodoPagoRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PutAsync(url, content);
            response.EnsureSuccessStatusCode();

            Console.WriteLine("Método de pago actualizado exitosamente.");
        }

        // Eliminar un método de pago
        public static async Task DeleteMetodoPagoAsync(int id)
        {

            var url = $"MetodoPago/{id}"; 

            HttpResponseMessage response = await ClienteHttp.DeleteAsync(url);
            response.EnsureSuccessStatusCode();

            Console.WriteLine("Método de pago eliminado exitosamente.");
        }

        //Ordenes
        // Obtener todas las órdenes
        public static async Task<List<Orden>> GetOrdenesAsync()
        {
            var url = "Orden";

            try
            {
                HttpResponseMessage response = await ClienteHttp.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();


                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Orden>>(responseBody);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error al obtener las órdenes: {ex.Message}");
                return null;
            }
        }

        // Obtener una orden por ID
        public static async Task<Orden> GetOrdenByIdAsync(int id)
        {
            var url = $"Orden/{id}";

            try
            {
                HttpResponseMessage response = await ClienteHttp.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();


                return Newtonsoft.Json.JsonConvert.DeserializeObject<Orden>(responseBody);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error al obtener la orden: {ex.Message}");
                return null;
            }
        }

        // Guardar una nueva orden
        public static async Task SaveOrdenAsync(OrdenRequest ordenRequest)
        {
            var url = "Orden";

            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(ordenRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await ClienteHttp.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                Console.WriteLine("Orden guardada exitosamente.");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error al guardar la orden: {ex.Message}");
            }
        }

        // Actualizar una orden
        public static async Task UpdateOrdenAsync(int id, OrdenRequest ordenRequest)
        {
            var url = $"Orden/{id}";

            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(ordenRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await ClienteHttp.PutAsync(url, content);
                response.EnsureSuccessStatusCode();

            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error al actualizar la orden: {ex.Message}");
            }
        }

        // Eliminar una orden
        public static async Task DeleteOrdenAsync(int id)
        {
            var url = $"Orden/{id}";

            try
            {
                HttpResponseMessage response = await ClienteHttp.DeleteAsync(url);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error al eliminar la orden: {ex.Message}");
            }
        }

        //Promocion
        public static async Task<List<Promocion>> GetPromocionesAsync()
        {
            var url = "Promocion";

            HttpResponseMessage response = await ClienteHttp.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Promocion>>(responseBody);
        }

        public static async Task<Promocion> GetPromocionByIdAsync(int id)
        {
            var url = $"Promocion/{id}";

            HttpResponseMessage response = await ClienteHttp.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Promocion>(responseBody);
        }

        public static async Task SavePromocionAsync(PromocionRequest promocionRequest)
        {
            var url = "Promocion";

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(promocionRequest);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

        }

        public static async Task UpdatePromocionAsync(int id, PromocionRequest promocionRequest)
        {
            var url = $"Promocion/{id}";

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(promocionRequest);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PutAsync(url, content);
            response.EnsureSuccessStatusCode();

            
        }

        public static async Task DeletePromocionAsync(int id)
        {
            var url = $"Promocion/{id}";

            HttpResponseMessage response = await ClienteHttp.DeleteAsync(url);
            response.EnsureSuccessStatusCode();

        }

        // OrdenDetalle POST
        public static async Task SaveOrdenDetalleAsync(OrdenDetalleRequest ordenDetalleRequest)
        {
            var url = "OrdenDetalle";

            string json = JsonConvert.SerializeObject(ordenDetalleRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

        }

        // OrdenEstado GET
        public static async Task<List<OrdenEstado>> GetOrdenEstadosAsync()
        {
            var url = "OrdenEstado";

            HttpResponseMessage response = await ClienteHttp.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<OrdenEstado>>(responseBody);
        }

        // ProductoTipo GET
        public static async Task<List<ProductoTipo>> GetProductoTiposAsync()
        {
            var url = "ProductoTipo";

            HttpResponseMessage response = await ClienteHttp.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<ProductoTipo>>(responseBody);
        }

        // PromocionDetalle POST
        public static async Task SavePromocionDetalleAsync(PromocionDetalleRequest promocionDetalleRequest)
        {
            var url = "PromocionDetalle";

            string json = JsonConvert.SerializeObject(promocionDetalleRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

        }

        // PlatilloIngrediente POST
        public static async Task SavePlatilloIngredienteAsync(PlatilloIngredienteRequest platilloIngredienteRequest)
        {
            var url = "PlatilloIngrediente";

            string json = JsonConvert.SerializeObject(platilloIngredienteRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ClienteHttp.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

        }

        public static async Task<DataTable> ReporteProducto()
        {
            var url = "Reportes/porProducto"; // Aquí colocas el endpoint adecuado

            try
            {
                // Realizamos la solicitud HTTP de manera asíncrona
                HttpResponseMessage response = await ClienteHttp.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Garantiza que la respuesta sea exitosa

                string responseBody = await response.Content.ReadAsStringAsync();

                // Convertimos la respuesta a DataTable
                var dataTable = JsonConvert.DeserializeObject<DataTable>(responseBody);

                return dataTable;
            }
            catch (Exception ex)
            {
                // En caso de error, se captura y se imprime
                Console.WriteLine($"Error al obtener el DataTable: {ex.Message}");
                return null;
            }
        }

        public static async Task<DataTable> Top10(string fechaInicio, string fechaFin)
        {
            var url = $"Reportes/Top10/{fechaInicio}/{fechaFin}"; // Aquí colocas el endpoint adecuado

            try
            {
                // Realizamos la solicitud HTTP de manera asíncrona
                HttpResponseMessage response = await ClienteHttp.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Garantiza que la respuesta sea exitosa

                string responseBody = await response.Content.ReadAsStringAsync();

                // Convertimos la respuesta a DataTable
                var dataTable = JsonConvert.DeserializeObject<DataTable>(responseBody);

                return dataTable;
            }
            catch (Exception ex)
            {
                // En caso de error, se captura y se imprime
                Console.WriteLine($"Error al obtener el DataTable: {ex.Message}");
                return null;
            }
        }

        public static async Task<DataTable> ReporteMetodoPago()
        {
            var url = "Reportes/PorMetodoPago"; // Aquí colocas el endpoint adecuado

            try
            {
                // Realizamos la solicitud HTTP de manera asíncrona
                HttpResponseMessage response = await ClienteHttp.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Garantiza que la respuesta sea exitosa

                string responseBody = await response.Content.ReadAsStringAsync();

                // Convertimos la respuesta a DataTable
                var dataTable = JsonConvert.DeserializeObject<DataTable>(responseBody);

                return dataTable;
            }
            catch (Exception ex)
            {
                // En caso de error, se captura y se imprime
                Console.WriteLine($"Error al obtener el DataTable: {ex.Message}");
                return null;
            }
        }

        public static async Task<DataTable> ReporteOrdenes()
        {
            var url = "Reportes/Ordenes"; // Aquí colocas el endpoint adecuado

            try
            {
                // Realizamos la solicitud HTTP de manera asíncrona
                HttpResponseMessage response = await ClienteHttp.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Garantiza que la respuesta sea exitosa

                string responseBody = await response.Content.ReadAsStringAsync();

                // Convertimos la respuesta a DataTable
                var dataTable = JsonConvert.DeserializeObject<DataTable>(responseBody);

                return dataTable;
            }
            catch (Exception ex)
            {
                // En caso de error, se captura y se imprime
                Console.WriteLine($"Error al obtener el DataTable: {ex.Message}");
                return null;
            }
        }

        public static async Task<DataTable> StockIngrediente()
        {
            var url = "Reportes/StockIngredientes"; // Aquí colocas el endpoint adecuado

            try
            {
                // Realizamos la solicitud HTTP de manera asíncrona
                HttpResponseMessage response = await ClienteHttp.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Garantiza que la respuesta sea exitosa

                string responseBody = await response.Content.ReadAsStringAsync();

                // Convertimos la respuesta a DataTable
                var dataTable = JsonConvert.DeserializeObject<DataTable>(responseBody);

                return dataTable;
            }
            catch (Exception ex)
            {
                // En caso de error, se captura y se imprime
                Console.WriteLine($"Error al obtener el DataTable: {ex.Message}");
                return null;
            }
        }

    }
}
