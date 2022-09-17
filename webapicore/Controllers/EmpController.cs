using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapicore.Model;
using webapicore.Model.DataContext;

namespace webapicore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly DataContext db;
        public EmpController(DataContext _db)
        {
            db = _db;   
        }

        [HttpPost]
        public dynamic postdata(Employee e)
        {
            db.employees.Add(e);
            db.SaveChanges();
            return ("succsee");
        }

    }
}
