using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Processing.Interfaces;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : Controller
    {
        private readonly ILinkProcessor processor;

        public LinkController(ILinkProcessor linkProcessor) => processor = linkProcessor;

        [HttpGet("link-types")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Dictionary<string, string>> GetLinkTypesApi()
        {
            Dictionary<string, string> result = processor.GetLinkTypes();

            return Ok(result);
        }
    }
}
