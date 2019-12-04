using KitchenManagerCommand.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using KitchenManagerQuery.Queries.Pantry;
using KitchenManagerCommand.Commands.Pantry;

namespace Kitchen_Manager.Controllers
{
    public class PantryController : ControllerBase
    {
        [HttpGet]
        [Route("pantry")]
        public List<KitchenManagerQuery.Models.Contents> GetPantryItems()
        {
            GetItemsFromPantry temp = new GetItemsFromPantry();
            return temp.GetItems();
        }

        [HttpGet]
        [Route("pantry/{id}")]
        public KitchenManagerQuery.Models.Contents GetPantryItem(Guid Id)
        {
            GetItemFromPantry temp = new GetItemFromPantry();
            return temp.GetItem(Id);
        }

        [HttpPost]
        [Route("pantry")]
        public ActionResult AddPantryItem([FromBody]Contents contents)
        {
            AddItemToPantry temp = new AddItemToPantry();
            temp.AddItem(contents);
            return Ok();
        }

        [HttpPost]
        [Route("pantry/{id}")]
        public ActionResult UpdatePantryItem([FromBody]Contents contents, Guid Id)
        {
            UpdateItemToPantry temp = new UpdateItemToPantry();
            contents.Id = Id;
            temp.UpdateItem(contents);
            return Ok();
        }

        [HttpDelete]
        [Route("pantry/{Id}")]
        public ActionResult DeletePantryItem(Guid Id)
        {
            DeleteItemFromPantry temp = new DeleteItemFromPantry();
            temp.DeleteItem(Id);

            return Ok();
        }
    }
}
