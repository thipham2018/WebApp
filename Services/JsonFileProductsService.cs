using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class JsonFileProductsService
    {
        public JsonFileProductsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; 
        }
        private string JsonFileName
        {
            get { return System.IO.Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }
    }
}
