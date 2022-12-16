using Exam.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RealtorController : Controller
    {
        private DBContext dbContext = new DBContext();
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dbContext.Realtors);
        }
        
        [HttpPut]
        public IActionResult Put(string name)
        {
            Realtor realtor = new Realtor(name);
            dbContext.Realtors.Add(realtor);
            dbContext.SaveChanges();
            return Ok();
        }
        
        [HttpDelete]
        public IActionResult Delete(int rieltorId)
        {
            Realtor realtor = dbContext.Realtors.Find(rieltorId);
            dbContext.Realtors.Remove(realtor);
            var list = dbContext.ApartmentRealtors.Where(i => i.RieltorId == rieltorId);
            foreach (var r in list)
            {
                dbContext.ApartmentRealtors.Remove(r);
            }
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
