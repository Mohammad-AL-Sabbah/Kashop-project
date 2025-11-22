using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASHOP.DAL.DTOs.Request
{
    public class CategoryRequest
    {
          public List<CategoryTranslationRequest> translations { get; set; }
    }
}
