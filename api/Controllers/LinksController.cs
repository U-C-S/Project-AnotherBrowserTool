using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Satellite.Models;

namespace Satellite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        [HttpGet("{name}")]
        public ActionResult<ICollection<Link>> GetLinksInFolder(string name)
        {
            return new Link[] {
                new Link {
                    id = Guid.NewGuid(),
                    name = "YouTube",
                    url = "https://www.youtube.com/",
                    createdOn = DateTime.Now,
                    updatedOn = null
                },
                new Link {
                    id = Guid.NewGuid(),
                    name = "Reddit",
                    url = "https://www.reddit.com/",
                    createdOn = DateTime.Now,
                    updatedOn = null
                }
            };
        }
    }
}
