using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApiNasaExample.Models;
using WebApiNasaExample.Services;

namespace WebApiNasaExample.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly WebServices webServices;

        //DI being peformed in HomeController
        //Sets up HttpClient and Controller
        public HomeController(WebServices webServices)
        {
            this.webServices = webServices;
        }

        //Change to public async Task<IActionResult>
        public async Task<IActionResult> Index()
        {
            //await webservice
            var asyncResult = await webServices.GetData("https://api.nasa.gov/planetary/apod?api_key=viSIKiso19UTU3msKwBiU8BiNm7i8g4pmcNfRq9y");
            
            return View(asyncResult);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
