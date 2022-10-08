using Microsoft.AspNetCore.Mvc;
using POS.Models;

namespace POS.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddItem()
        {
            return View();
        }
        public IActionResult UpdateItem()
        {
            return View();
        }
        public IActionResult DetailItem()
        {
            Items objItem = new Items();
            objItem.Id = 1;
            objItem.ItemName = "Laptop";
            objItem.Serial = 1;
            objItem.ItemCode = "ITM-" + objItem.Serial.ToString();
            objItem.Price = 100;
            objItem.Qunatity = 20;
            return View(objItem);
        }
        public IActionResult AllItem()
        {
            return View();
        }
        public IActionResult DeleteItem()
        {
            return View();
        }
    }
}
