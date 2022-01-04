using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Satellite.Models;
using System.Diagnostics;

namespace Satellite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        [HttpGet("{name}")]
        public ActionResult<ICollection<Link>> GetLinksInFolder(string name)
        {
            Debug.WriteLine($"GetLinksInFolder - {name}");
            return new Link[] {
                new Link {
                    Id = Guid.NewGuid(),
                    Name = "YouTube",
                    Url = "https://www.youtube.com/",
                    CreatedOn = DateTime.Now,
                    UpdatedOn = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Name = "Reddit",
                    Url = "https://www.reddit.com/",
                    CreatedOn = DateTime.Now,
                    UpdatedOn = null
                }
            };
        }
    }
}
