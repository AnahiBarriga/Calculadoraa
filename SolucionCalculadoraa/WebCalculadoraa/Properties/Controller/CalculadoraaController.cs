using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculadoraa.Properties.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]

    public class CalculadoraaController : ControllerBase
    {
        
        [HttpGet]
        [Route("suma")]
        public int sumaget(int a, int b)
        {
            return a + b;
        }
        [HttpPost]
        [Route("suma")]
        public int sumapost([FromHeader] int a, [FromHeader] int b)
        {
            return a + b;
        }

        [HttpGet]
        [Route("resta")]
        public int restaget(int a, int b)
        {
            return a - b;
        }
        [HttpPost]
        [Route("resta")]
        public int restapost([FromHeader] int a, [FromHeader] int b)
        {
            return a - b;
        }
        [HttpGet]
        [Route("multi")]
        public int multiget(int a, int b)
        {
            return a * b;
        }
        [HttpPost]
        [Route("multi")]
        public int multipost([FromHeader] int a, [FromHeader] int b)
        {
            return a * b;
        }
        [HttpGet]
        [Route("div")]
        public float divget(float a, float b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                return a / b;
            }
        }
        [HttpPost]
        [Route("division")]
        public float  divisionpost([FromHeader] float a, [FromHeader] float b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                return a / b;
            }
        }
    }
}
