using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikSwe.Models
{
    public class Tuik
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string TableColumnName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; } // wwwroot içindeki 1.jpg gibi
        public int CategoryId { get; set; }
    }
}
