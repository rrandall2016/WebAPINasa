using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNasaExample.Models
{
    public class NasaData
    {
        //Model Data
        //Install Newtonsoft.json package
        
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        //Provides an object representation of a-
        //- uniform resource identifier (URI) and easy access to the parts of the URI.
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("explanation")]
        public string Explanation { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }



    }
}
