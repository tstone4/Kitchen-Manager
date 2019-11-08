using Kitchen_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen_Manager.Controllers
{
    public class PantryController : ControllerBase
    {
        [HttpGet]
        [Route("pantry")]
        public Contents[] Get()
        {
            Contents[] contents = new Contents[2];
            Contents temp = new Contents();
            temp.Name = "Bread";
            temp.Amount = "1 Loaf";
            contents[0] = temp;
            temp = new Contents();
            temp.Name = "Cans of Tomatoes";
            temp.Amount = "Three";
            contents[1] = temp;
            return contents;
        }
    }
}
