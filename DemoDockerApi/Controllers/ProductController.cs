using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDockerApi.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDockerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task <ActionResult<List<Product>>> Get()
        {
            {
                try
                {
                    //var result = new List<Product>();
                    //for (int i = 0; i < 5; i++)
                    //{
                    //    Product obj = new Product();
                    //    obj.Id = i;
                    //    obj.Name = "sagar";
                    //    obj.Price = i;
                    //    result.Add(obj);
                    //}
                    var result = await _productRepository.GetProducts();
                    return Ok(result);
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
            }
        }
    }
}