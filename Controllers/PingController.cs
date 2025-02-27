using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace marcelo.Controllers
{
    [Route("[controller]")]
    public class PingController : Controller
    {
        [HttpGet("")]
        public IActionResult Ping()
        {
            return Ok("pong");
        }

        [HttpGet("hello-world")]
        public IActionResult HelloWorld()
        {
            return Ok("hello, world!");
        }
    }
}