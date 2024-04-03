using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace poncedeleonJMC_1MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string SayHi(string name ="Stranger"){
            return $"Hello {name}, hope you are doing well!";
        }
    }
}