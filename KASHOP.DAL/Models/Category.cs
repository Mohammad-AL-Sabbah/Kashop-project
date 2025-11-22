using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASHOP.DAL.Models
{
    public class Category : BaseModel
    {
        public List<CategoryTranslations> translations { get; set; }
    }
}
