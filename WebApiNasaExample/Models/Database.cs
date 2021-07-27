using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNasaExample.Models
{
    public class Database
    {
   
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Intelligence { get; set; }
    }
}
