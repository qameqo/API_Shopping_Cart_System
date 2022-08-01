using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1_API.Models;

namespace WebApplication1_API.Controllers
{
    [Route("api/[Controller]/")]
    [ApiController]
    public class FlagController : Controller
    {
        [HttpGet]
        [Route("Get")]
        public string FlagAll()
        {
            return "OK";
        }
        [HttpGet]
        [Route("SetFlag/{key}")]
        public bool SetFlag(string key)
        {
            bool result = false;
            if (key.Trim().ToUpper() == "Y")
            {
                result = true;
            }
            return result;
        }
    }
}
