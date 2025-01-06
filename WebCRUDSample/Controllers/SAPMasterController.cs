using Microsoft.AspNetCore.Mvc;
using WebCRUDSample.Interface;
using WebCRUDSample.Models;

namespace WebCRUDSample.Controllers
{
    public class SAPMasterController : Controller
    {
        private readonly IItemCategory crud;
        public SAPMasterController(IItemCategory crud)
        {
            this.crud = crud;
        }
        public IActionResult GetItem()
        {
            List<ItemCategory> IC = crud.ItemCategoryList();
            //return View(IC);
            //var data = new List<dynamic>
            //{
            //    new { id = 1, first = "Sonu", last = "sharma", handle = "Gupta" },
            //    new { id = 2, first = "Jacob", last = "Thornton", handle = "fat" },
            //    new { id = 3, first = "Larry", last = "the Bird", handle = "twitter" },
            //    new { id = 4, first = "Mark", last = "Otto", handle = "mdo" },
            //    new { id = 5, first = "Jacob", last = "Thornton", handle = "fat" },
            //    new { id = 6, first = "Larry", last = "the Bird", handle = "twitter" },
            //    new { id = 7, first = "Mark", last = "Otto", handle = "mdo" },
            //    new { id = 8, first = "Jacob", last = "Thornton", handle = "fat" },
            //    new { id = 9, first = "Amit", last = "Kumar ", handle = "Rajput" },
            //};
            ViewBag.TableData = IC;
            return View(IC);
        }
    }
}
