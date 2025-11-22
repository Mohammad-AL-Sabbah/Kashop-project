using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASHOP.DAL.Models
{
    public class CategoryTranslations
    {
        public int Id { get; set; }
        public string Name { get; set;  } 
        public string Language { get; set; } 
        public int categoryId { get; set; }
        public Category Category { get; set; }
    }
}
