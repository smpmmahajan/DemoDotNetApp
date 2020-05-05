using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDockerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            List<Product> lst = new List<Product>();
            for (int i = 0; i < 3; i++)
            {
                Product obj = new Product();
                obj.Id = i;
                obj.Name = "sagar" + i;
                obj.Price = i + 10 * 2;
                lst.Add(obj);
            }
            return Ok(lst);
        }
    }
}