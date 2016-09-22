using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Controllers
{
    public class TransactionController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View(db.Transactions.Include(transactions => transactions.Inventory).ToList());
        }
        public ActionResult Create()
        {
            ViewBag.InventoryId = new SelectList(db.Inventories, "InventoryId", "Item");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Transaction transaction, int id)
        {
            var item = db.Inventories.Where(i => i.InventoryId == id);
            
            db.Transactions.Add(transaction);
            
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
