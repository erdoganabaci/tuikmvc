using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikSwe.Models
{
    public class TuikCategoryModel
    {
        public Tuik Tuik { get; set; }
        public IEnumerable<Tuik> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
