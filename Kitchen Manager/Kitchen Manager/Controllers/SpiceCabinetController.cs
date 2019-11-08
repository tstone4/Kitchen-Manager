using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen_Manager.Controllers
{
    public class SpiceCabinetController : ControllerBase
    {
        [HttpGet]
        [Route("spice")]
        public string[] Get()
        {
            string[] contents = new string[2] { "Onion Powder", "Paprika" };
            return contents;
        }
    }
}
