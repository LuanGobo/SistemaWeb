using Microsoft.AspNetCore.Mvc;
using SalesWeb.Services;
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
    }
}
