using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Services
{
    public class ProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient httpClient)
        {
            _http = httpClient;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _http.GetFromJsonAsync<List<Product>>("https://fakestoreapi.com/products");
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<Product>($"https://fakestoreapi.com/products/{id}");
        }
    }
}
