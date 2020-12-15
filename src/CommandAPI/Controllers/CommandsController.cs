using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "this", "is", "hard", "coded" };
        }
    }
}

/** 
 *   The API we are building:
 *
 *   Verb   URI                 Operation           Description
 *   GET    /api/commands       Read                Read all command resources
 *   GET    /api/commands/{Id}  Read                Read a single resource (by Id)
 *   POST   /api/commands       Create              Create a new resource
 *   PUT    /api/commands/{Id}  Update (Full)       Update all of a single resource (by Id)
 *   PATCH  /api/commands/{Id}  Update (Partial)    Update part of a single resource (by Id)
 *   DELETE /api/commands/{Id}  Delete              Delete a single resource (by Id)
 */