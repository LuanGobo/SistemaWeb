using Microsoft.AspNetCore.Mvc;
using SalesWeb.Services;
using SalesWeb.Models;
using System.Runtime.CompilerServices;

namespace SalesWeb.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sallerService;

        public SellersController(SellerService sallerService)
        {
            _sallerService = sallerService;
        }

        public IActionResult Index()
        {
            var list = _sallerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sallerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
