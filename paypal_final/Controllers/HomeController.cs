using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using paypal_final.Data;
using paypal_final.Models;

namespace paypal_final.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _context;

        // Constructor receives the context through dependency injection.
        public HomeController(ApplicationDbContext context)
        {
            this._context = context;
        }

        // Home page shows list of items. Item price is set through ViewBag.
        public IActionResult Index()
        {
            ViewBag.TotalPrice = "3.55";
            var items = _context.IPNs;
            return View(items);
        }

        // This method receives and stores the Paypal transaction details.
        [HttpPost]
        public JsonResult PaySuccess([FromBody]IPN ipn)
        {
            try
            {
                _context.IPNs.Add(ipn);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
            return Json(ipn);
        }

        // Show transaction detail. 
        public IActionResult FinishShopping(string paymentID)
        {
            IPN transaction = _context.IPNs.Where(t => t.paymentID == paymentID).FirstOrDefault();
            return View(transaction);
        }

    }
}
