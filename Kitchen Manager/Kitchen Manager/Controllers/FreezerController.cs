using KitchenManagerCommand.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen_Manager.Controllers
{
    public class FreezerController : ControllerBase
    {
        [HttpGet]
        [Route("freezer")]
        public Contents[] Get()
        {
            Contents[] contents = new Contents[2];
            Contents temp = new Contents();
            temp.Name = "Frozen Peas";
            temp.Ounces = 16;
            contents[0] = temp;
            temp = new Contents();
            temp.Name = "Frozen Corn";
            temp.Ounces = 32;
            contents[1] = temp;
            return contents;
        }
    }
}
