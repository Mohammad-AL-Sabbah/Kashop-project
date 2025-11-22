using KASHOP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASHOP.DAL.DTOs.Response
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public Status status { get; set; }
        public List<CategoryTranslationResponse> translations { get; set; }
    }
}
