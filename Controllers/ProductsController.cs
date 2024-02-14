using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
        public class ProductsController : ControllerBase
        {
            public ProductsController(JsonFileProductsService productService)
            {
                 this.ProductService = productService;
            }
             public JsonFileProductsService ProductService { get; }

            [HttpGet]
            public IEnumerable<Product> Get()
            {
                  return ProductService.GetProducts();
             }

    }
}
