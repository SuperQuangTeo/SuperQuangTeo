using Microsoft.AspNetCore.Mvc;
using Project.Logics;
using Project.Models;
using System.Collections.Generic;

namespace Project.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult List(int Id)
        {
            BrandManager brandManager = new BrandManager();
            List<Brand> brandList = brandManager.getBrands1(Id);
            return View(brandList);
        }
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult DoAdd(Brand newBrand)
        {
            BrandManager brandManager = new BrandManager();
            brandManager.addBrand(newBrand);
            return RedirectToAction("List","Brand");
        }
        public IActionResult Update(int Id)
        {
            BrandManager brandManager = new BrandManager();
            Brand bra = brandManager.getBrand(Id);
            return View(bra);
        }
        public IActionResult DoUpdate(Brand newBrand)
        {
            BrandManager brandManager = new BrandManager();
            brandManager.updateBrand(newBrand);
            return RedirectToAction("List","Brand");
        }

    }
}
