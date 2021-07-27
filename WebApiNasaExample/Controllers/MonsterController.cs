using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiNasaExample.Services;

namespace WebApiNasaExample.Controllers
{
    public class MonsterController : Controller
    {
        private readonly MonsterServices webServices;

        public MonsterController(MonsterServices webServices)
        {
            this.webServices = webServices;
        }
        public async Task<IActionResult> Index()
        {
            var result = await webServices.GetList();

            result.Results = result.Results.Where(x => x.Name.StartsWith("D", StringComparison.OrdinalIgnoreCase)).ToArray(); 

            return View(result);
        }
        [Route("/Monster/Details/{name}")]
        public async Task<IActionResult> Details(string name)
        {
            var result2 = await webServices.GetDetails(name);

            return View(result2);
        }
    }
}
