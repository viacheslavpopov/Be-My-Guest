using System.Threading.Tasks;
using RestSharp;
using System;

namespace BeMyGuest.Models
{
    class EvidencesApiHelper
    {
        public static async Task<string> GetAll()
        {
            RestClient client = new RestClient("http://localhost:5001/api");
            RestRequest request = new RestRequest($"evidences", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            int StatusCode = (int)response.StatusCode;
            return response.Content;
        }
        public static async Task<string> Get(int id)
        {
            RestClient client = new RestClient("http://localhost:5001/api");
            RestRequest request = new RestRequest($"evidences/{id}", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }
        public static async Task Post(string newCovidData)
        {
            RestClient client = new RestClient("http://localhost:5001/api");
            RestRequest request = new RestRequest($"evidences", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(newCovidData);
            var response = await client.ExecuteTaskAsync(request);
        }
        public static async Task Put(int id, string newCovidData)
        {
            RestClient client = new RestClient("http://localhost:5001/api");
            RestRequest request = new RestRequest($"evidences{id}", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(newCovidData);
            var response = await client.ExecuteTaskAsync(request);
        }
        public static async Task Delete(int id)
        {
            RestClient client = new RestClient("http://localhost:5001/api");
            RestRequest request = new RestRequest($"evidences{id}", Method.DELETE);
            request.AddHeader("Content-Type", "application/json");
            var response = await client.ExecuteTaskAsync(request);
        }
    }
}