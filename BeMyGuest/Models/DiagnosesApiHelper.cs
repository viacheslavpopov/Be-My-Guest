using System.Threading.Tasks;
using RestSharp;
using System;

namespace BeMyGuest.Models
{
    class DiagnosesApiHelper
    {
        public static async Task<string> GetAll()
        {
            RestClient client = new RestClient("http://localhost:5001/api");
            RestRequest request = new RestRequest($"diagnoses", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }
        public static async Task<string> Get(int id)
        {
            RestClient client = new RestClient("http://localhost:5001/api");
            RestRequest request = new RestRequest($"diagnoses/{id}", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }
        public static async Task Post(string newDiangosis)
        {
            RestClient client = new RestClient("http://localhost:5001/api");
            RestRequest request = new RestRequest($"diagnoses", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(newDiangosis);
            var response = await client.ExecuteTaskAsync(request);
        }
        public static async Task Put(int id, string newDiangosis)
        {
            RestClient client = new RestClient("http://localhost:5001/api");
            RestRequest request = new RestRequest($"diagnoses{id}", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(newDiangosis);
            var response = await client.ExecuteTaskAsync(request);
        }
        public static async Task Delete(int id)
        {
            RestClient client = new RestClient("http://localhost:5001/api");
            RestRequest request = new RestRequest($"diagnoses{id}", Method.DELETE);
            request.AddHeader("Content-Type", "application/json");
            var response = await client.ExecuteTaskAsync(request);
        }
    }
}