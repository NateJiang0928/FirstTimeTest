using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace justfortest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string get() 
        {
            return "good";
        }
    }
}
