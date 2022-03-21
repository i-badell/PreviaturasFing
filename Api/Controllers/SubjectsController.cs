using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PreviaturasFing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        public SubjectsController(ILogger<SubjectsController> logger)
        {
               
        }
    }
}
