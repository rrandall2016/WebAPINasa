using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNasaExample.Models
{
    public class ResultObject
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public MonsterData[] Results { get; set; }
    }
}
