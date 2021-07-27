using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNasaExample.Models
{
    public class Details
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alignment")]
        public string Alignment { get; set; }
    }
}
