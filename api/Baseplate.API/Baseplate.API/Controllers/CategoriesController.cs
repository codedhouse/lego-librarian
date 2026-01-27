using Baseplate.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Baseplate.API.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CategoryDto>> GetCategories()
        {
            return Ok(CategoriesDataStore.Current.Categories);
        }

        [HttpGet("{id}")]
        public ActionResult<CategoryDto> GetCategory(int id)
        {
            var categoryToReturn = CategoriesDataStore.Current.Categories.FirstOrDefault(d => d.Id == id);

            if (categoryToReturn == null)
            {
                return NotFound();
            }

            return Ok(categoryToReturn);
        }
    }
}
