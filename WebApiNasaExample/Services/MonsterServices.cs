using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApiNasaExample.Models;

namespace WebApiNasaExample.Services
{
    public class MonsterServices
    {
        private const string baseUrl = "https://www.dnd5eapi.co/api/monsters";
        private readonly HttpClient httpClient;
        //Dependency Injection
        //The constructor creates the httpClient object inside the parameters
        public MonsterServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ResultObject> GetList()
        {
            //Get request at endpoint and perform deserialization of JSON into an object
            //Add Newtonsoft.Json
            //Return null if first return fails
            try
            {
                return await httpClient.GetFromJsonAsync<ResultObject>(baseUrl);
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("HTTP Request Error");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The content is not supported");
            }
            catch (JsonException)
            {
                Console.WriteLine("Bad JSON");
            }
            return null;
        }
        public async Task<Details> GetDetails(string name)
        {
            //Get request at endpoint and perform deserialization of JSON into an object
            //Add Newtonsoft.Json
            //Return null if first return fails
            try
            {
                return await httpClient.GetFromJsonAsync<Details>($"{baseUrl}/{name}");
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("HTTP Request Error");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The content is not supported");
            }
            catch (JsonException)
            {
                Console.WriteLine("Bad JSON");
            }
            return null;
        }

    }
}
