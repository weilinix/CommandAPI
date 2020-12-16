using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using CommandAPI.Data;
using CommandAPI.Models;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;
        public CommandsController(ICommandAPIRepo repository)
        {
            _repository = repository;
        }

        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "this", "is", "hard", "coded" };
        // }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if (commandItem == null)
            {
                return NotFound();
            }
            return Ok(commandItem);
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