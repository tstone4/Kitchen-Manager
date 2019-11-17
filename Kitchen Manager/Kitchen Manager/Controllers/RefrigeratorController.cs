using Kitchen_Manager.Models;
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
        public Contents[] Get()
        {

            Contents[] contents = new Contents[2];
            Contents temp = new Contents();
            temp.Name = "Milk";
            temp.Ounces = 128;
            contents[0] = temp;
            temp = new Contents();
            temp.Name = "Eggs";
            temp.Ounces = 16;
            contents[1] = temp;
            return contents;
    }
    }
}
