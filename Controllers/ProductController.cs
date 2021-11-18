using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithoutUsingInterface.Models;
using WebApiWithoutUsingInterface.ProductData;

namespace WebApiWithoutUsingInterface.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        MockProducts products=new MockProducts();

        
        [HttpGet]
        [Route("api/{Controller}")]
        public IActionResult GetProducts()
        {
            return Ok(products.GetProducts());
        }


        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = products.GetProduct();

            if (product == null)
            {
                return NotFound($"student with  id : {id } was not found");
            }
            return Ok(products);

            //    [HttpPost]
            //    [Route("api/[Controller]")]
            //public IActionResult PostProduct(Products products )
            //{

            //    return Created(HttpContext.Request.Scheme + "//" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + products.Id, products);

            //}
        }
    }
}
