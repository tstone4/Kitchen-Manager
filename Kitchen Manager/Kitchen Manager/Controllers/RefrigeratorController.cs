using KitchenManagerCommand.Commands.Refrigerator;
using KitchenManagerCommand.Models;
using KitchenManagerQuery.Queries.Refrigerator;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Kitchen_Manager.Controllers
{
    public class RefrigeratorController : ControllerBase
    {
        [HttpGet]
        [Route("refrigerator")]
        public List<KitchenManagerQuery.Models.Contents> GetRefrigeratorContents()
        {
            GetItemsFromRefrigerator temp = new GetItemsFromRefrigerator();
            return temp.GetItems();
        }

        [HttpGet]
        [Route("refrigerator/{id}")]
        public KitchenManagerQuery.Models.Contents GetRefrigeratorContents(Guid Id)
        {
            GetItemFromRefrigerator temp = new GetItemFromRefrigerator();
            return temp.GetItem(Id);
        }

        [HttpPost]
        [Route("refrigerator")]
        public ActionResult AddItemToRefrigerator([FromBody]Contents contents)
        {
            AddItemToRefrigerator temp = new AddItemToRefrigerator();
            temp.AddItem(contents);
            return Ok();
        }

        [HttpDelete]
        [Route("refrigerator/{id}")]
        public ActionResult DeleteItemFromRefrigerator(Guid Id)
        {
            DeleteItemFromRefrigerator temp = new DeleteItemFromRefrigerator();
            temp.DeleteItem(Id);
            return Ok();
        }

        [HttpPost]
        [Route("refrigerator/{id}")]
        public ActionResult UpdateItemToRefrigerator([FromBody]Contents contents, Guid Id)
        {
            UpdateItemToRefrigerator temp = new UpdateItemToRefrigerator();
            contents.Id = Id;
            temp.UpdateItem(contents);
            return Ok();
        }
    }
}
