using Microsoft.AspNetCore.Mvc;
using Project.Logics;
using Project.Models;
using System.Collections.Generic;

namespace Project.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            BrandManager br = new BrandManager();
            List<Brand> brand = br.getBrands();
            ViewBag.Brand = brand;
            return View();
        }

        public IActionResult DoAdd(Product newPro)
        {
            ProductManager pro = new ProductManager();
            BrandManager br = new BrandManager();
            List<Product> product = pro.GetProducts1(0);
            List<Brand> brand = br.getBrands();
            ViewBag.Brand = brand;
            pro.AddProduct(newPro);
            return RedirectToAction("index","Home", product);
        }

        public IActionResult Detail(int Id)
        {
            ProductManager pro = new ProductManager();
            BrandManager br = new BrandManager();
            Product product = pro.GetProduct1(Id);
            Brand brand = br.getBrand(product.BrandId);
            ViewBag.Brand = brand;
            return View(product);
        }

        public IActionResult DoRemove(int Id)
        {
            ProductManager pro = new ProductManager();
            BrandManager br = new BrandManager();
            List<Product> product = pro.GetProducts1(0);
            List<Brand> brand = br.getBrands();
            ViewBag.Brand = brand;
            pro.DeleteProduct(Id);
            return RedirectToAction("index", "Home", product);
        }

        public IActionResult Update(int Id)
        {
            BrandManager br = new BrandManager();
            ProductManager pro = new ProductManager();
            Product product = pro.GetProduct(Id);
            List<Brand> brand = br.getBrands();
            ViewBag.Brand = brand;
            return View(product);
        }

        public IActionResult DoUpdate(Product newPro)
        {
            ProductManager pro = new ProductManager();
            BrandManager br = new BrandManager();
            List<Product> product = pro.GetProducts(0);
            List<Brand> brand = br.getBrands();
            ViewBag.Brand = brand;
            pro.UpdateProduct(newPro);
            return RedirectToAction("index", "Home", product);
        }
    }
}
