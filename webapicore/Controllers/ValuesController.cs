using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webapicore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public dynamic getdata()
        {
            string mangal = "mangalsingh"
            return mangal
        }
    }
}
