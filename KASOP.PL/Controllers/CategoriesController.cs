using KASHOP.DAL.Data;
using KASHOP.DAL.DTOs.Request;
using KASHOP.DAL.DTOs.Response;
using KASHOP.DAL.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace KASOP.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context ;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public CategoriesController(ApplicationDbContext context,IStringLocalizer<SharedResource>localizer)
        {
                       _context = context;
            this._localizer = localizer;
        }

        [HttpGet("")]

        public IActionResult index()
        {
            var categories = _context.Categories.Include(c=>c.translations).ToList();
            var response = categories.Adapt<List<CategoryResponse>>();

            return Ok(new {message= _localizer["Success"].Value, response });
        }

        [HttpPost("create")]

        public IActionResult  Create(CategoryRequest request)
        {
            var category = request.Adapt<Category>();
            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok(new { message = _localizer["success"].Value });
        }

    }
}
