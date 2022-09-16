using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapicore.Model;
using webapicore.Model.DataContext;

namespace webapicore.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly DataContext _db;
        public HomeController(DataContext db)
        {
            _db = db;
        }
        [HttpPost]
        public dynamic postdata(User u)
        {
            _db.users.Add(u);
            _db.SaveChanges();
            return "success";
        }
        [HttpGet]
        public dynamic getdata()
        {
           var data =  _db.users.ToList();
            return data;
        }
    }
}
