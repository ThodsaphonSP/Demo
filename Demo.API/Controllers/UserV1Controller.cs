using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [ApiVersion("1.0")]
    [Tags("User")]
    [Route("api/v{version:apiVersion}/User")]
    [ApiController]
    public class UserV1Controller : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "version 1";
        }
    }
}
