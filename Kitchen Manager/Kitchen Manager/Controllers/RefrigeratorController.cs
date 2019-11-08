using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen_Manager.Controllers
{
    public class RefrigeratorController : ControllerBase
    {
        [HttpGet]
        [Route("refrigerator")]
        public string[] Get()
        {
            string[] contents = new string[2] { "Eggs", "Milk" };
            return contents;
        }
    }
}
