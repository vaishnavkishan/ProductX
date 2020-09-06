using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductXController : ControllerBase
    {
        private readonly ProductXContext _db;

        public ProductXController(ProductXContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Test String");
        }
    }
}
