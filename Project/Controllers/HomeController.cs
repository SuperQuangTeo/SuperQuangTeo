using Microsoft.AspNetCore.Mvc;
using Project.Logics;
using Project.Models;
using System.Collections.Generic;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            ProductManager pro = new ProductManager();
            BrandManager br = new BrandManager();
            List<Product> product = pro.GetProducts1(id);
            List<Brand> brand = br.getBrands();
            ViewBag.Brand = brand;
            ViewBag.CurBrand = id;
            return View(product);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
