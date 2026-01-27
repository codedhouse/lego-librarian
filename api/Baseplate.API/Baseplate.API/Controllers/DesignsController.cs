using Baseplate.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Baseplate.API.Controllers
{
    [ApiController]
    [Route("api/designs")]
    public class DesignsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<DesignDto>> GetDesigns()
        {
            return Ok(DesignsDataStore.Current.Designs);
        }

        [HttpGet("{id}")]
        public ActionResult<DesignDto> GetDesign(int id)
        {
            var designToReturn = DesignsDataStore.Current.Designs.FirstOrDefault(d => d.Id == id);

            if (designToReturn == null)
            {
                return NotFound();
            }

            return Ok(designToReturn);
        }
    }
}
