using Exam.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class FlatController : Controller
    {
        private DBContext dbContext = new DBContext();
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dbContext.Apartments);
        }
        
        [HttpPut]
        public IActionResult Put(string name, int[] rieltorsId, string place, double square, decimal price, string image)
        {
            Apartment apartment = new Apartment(name, place, square, price, image);
            dbContext.Apartments.Add(apartment);
            int i = dbContext.Apartments.OrderBy(x => x.Id).Last().Id + 1;
            foreach(var r in rieltorsId)
            {
                dbContext.ApartmentRealtors.Add(new ApartmentRealtor(i, r));
            }
            dbContext.SaveChanges();
            return Ok();
        }
        
        [HttpDelete]
        public IActionResult Delete(int flatId)
        {
            Apartment apartment = dbContext.Apartments.Find(flatId);
            dbContext.Apartments.Remove(apartment);
            var list = dbContext.ApartmentRealtors.Where(i => i.FlatId == flatId);
            foreach (var r in list)
            {
                dbContext.ApartmentRealtors.Remove(r);
            }
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
