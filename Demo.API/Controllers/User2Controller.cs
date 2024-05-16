using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [ApiVersion("2.0")]
    [Tags("User")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class User2Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "version 2";
        }
    }
}