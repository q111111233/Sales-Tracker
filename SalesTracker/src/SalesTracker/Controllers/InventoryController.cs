using Microsoft.AspNetCore.Mvc;
using SalesTracker.Models;
using System;
using System.Linq;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SalesTracker.Controllers
{   
    public class InventoryController : Controller
    {    
        // GET: /<controller>/
        private ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RandomList( int count)
        {
            var randomList = db.Inventories.OrderBy(r => Guid.NewGuid()).Take(count);
            return Json(randomList);
        }
        [HttpPost]
        public IActionResult NewInventory(int newUnit, string newItem, int newCost, int newSalePrice)
        {
            Inventory newInventory = new Inventory(newUnit, newItem, newCost, newSalePrice);
            db.Inventories.Add(newInventory);
            db.SaveChanges();
            return Json(newInventory);
        }
    }
}
