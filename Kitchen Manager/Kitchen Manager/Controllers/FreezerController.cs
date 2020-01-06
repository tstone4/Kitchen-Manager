using KitchenManagerCommand.Models;
using KitchenManagerQuery.Queries.Freezer;
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
        public List<KitchenManagerQuery.Models.Contents> GetRefrigeratorContents()
        {
            GetItemsFromFreezer temp = new GetItemsFromFreezer();
            return temp.GetItems();
        }

        [HttpGet]
        [Route("freezer/{id}")]
        public KitchenManagerQuery.Models.Contents GetRefrigeratorContents(Guid Id)
        {
            GetItemFromFreezer temp = new GetItemFromFreezer();
            return temp.GetItem(Id);
        }

        [HttpPost]
        [Route("freezer")]
        public ActionResult AddItemToRefrigerator([FromBody]Contents contents)
        {
            AddItemToRefrigerator temp = new AddItemToRefrigerator();
            temp.AddItem(contents);
            return Ok();
        }

        [HttpDelete]
        [Route("freezer/{id}")]
        public ActionResult DeleteItemFromRefrigerator(Guid Id)
        {
            DeleteItemFromRefrigerator temp = new DeleteItemFromRefrigerator();
            temp.DeleteItem(Id);
            return Ok();
        }

        [HttpPost]
        [Route("freezer/{id}")]
        public ActionResult UpdateItemToRefrigerator([FromBody]Contents contents, Guid Id)
        {
            UpdateItemToRefrigerator temp = new UpdateItemToRefrigerator();
            contents.Id = Id;
            temp.UpdateItem(contents);
            return Ok();
        }
    }
}
