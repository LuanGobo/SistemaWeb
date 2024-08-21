using Microsoft.AspNetCore.Mvc;
using SalesWeb.Services;
using SalesWeb.Models;
using SalesWeb.Models.ViewModels;
using System.Runtime.CompilerServices;

namespace SalesWeb.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sallerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sallerService, DepartmentService departmentService)
        {
            _sallerService = sallerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _sallerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewmodel = new SellerFormViewModel { Departments = departments };
            return View(viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sallerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _sallerService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sallerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
