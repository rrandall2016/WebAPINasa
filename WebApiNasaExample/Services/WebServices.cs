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
    public class WebServices
    {
        //Services
        //add System.Net.Http collection
        //add services httpClient

        private readonly HttpClient httpClient;
        //Dependency Injection
        //The constructor creates the httpClient object inside the parameters
        public WebServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /*
         * 1.Async code can be used for both I/O-bound and CPU-bound code, but differently for each scenario.
           2.Async code uses Task<T> and Task, which are constructs used to model work being done in the background.
           3.The async keyword turns a method into an async method, which allows you to use the await keyword in its body.
           4.When the await keyword is applied, it suspends the calling method and yields control back to its caller until the awaited task is complete.
           5.await can only be used inside an async method.
        */
        public async Task<NasaData> GetData(string endPoint)
        {
            //Get request at endpoint and perform deserialization of JSON into an object
            //Add Newtonsoft.Json
            //Return null if first return fails
            try
            {
                return await httpClient.GetFromJsonAsync<NasaData>(endPoint);
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
