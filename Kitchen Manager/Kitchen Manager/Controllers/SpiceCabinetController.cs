using Kitchen_Manager.Models;
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
        public Contents[] Get()
        {
            Contents[] contents = new Contents[2];
            Contents temp = new Contents();
            temp.Name = "Paprika";
            temp.Ounces = 10;
            contents[0] = temp;
            temp = new Contents();
            temp.Name = "Onion Powder";
            temp.Ounces = 12;
            contents[1] = temp;
            return contents;
        }
    }
}
