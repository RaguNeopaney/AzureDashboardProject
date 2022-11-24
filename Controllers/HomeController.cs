using Dashboard.Data;
using Dashboard.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AuthDbContext _context;

        public HomeController(ILogger<HomeController> logger, AuthDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Table()
        {
            return View();
        }

        [HttpPost]
        public JsonResult HouseholdTable()
        {
            var householdsData = _context.Households.ToList();
            return Json(householdsData);
        }

        [HttpPost]
        public JsonResult ProductTable()
        {
            var productData = _context.Products.ToList();
            return Json(productData);
        }

        [HttpPost]
        public JsonResult TransactionTable()
        {
            var transactionData = _context.Transactions.ToList();
            List<TransactionViewModel> test = new List<TransactionViewModel>();
            foreach (var tran in transactionData)
            {
                TransactionViewModel test2 = new TransactionViewModel();
                test2.Basket_num = tran.Basket_num;
                test2.Purchase_date = tran.Purchase_date.ToShortDateString();
                test2.Spend = tran.Spend;
                test2.Units = tran.Units;
                test2.Store_region = tran.Store_region;
                test2.Week_num = tran.Week_num;
                test2.Year = tran.Year;
                test2.Product_num = tran.Product_num;
                test2.Hshd_num = tran.Hshd_num;
                test.Add(test2);
            }
            return Json(test);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}