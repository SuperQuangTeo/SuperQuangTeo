using Microsoft.AspNetCore.Mvc;
using Project.Logics;
using Project.Models;
using System.Collections.Generic;

namespace Project.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult List(int Id)
        {
            CategoryManager cateMan = new CategoryManager();
            List<Category> cate = cateMan.getCategories(Id);
            return View(cate);
        }

        public IActionResult Add()
        {            
            return View();
        }

        public IActionResult DoAdd(Category newCate)
        {
            CategoryManager cateMan = new CategoryManager();
            List<Category> cate = cateMan.getCategories(0);
            cateMan.addCategory(newCate);
            return RedirectToAction("List","Category", cate);
        }

        public IActionResult Update(int Id)
        {
            CategoryManager cateMan = new CategoryManager();
            Category cate = cateMan.GetCategory(Id);
            return View(cate);
        }
        public IActionResult DoUpdate(Category newCate)
        {
            CategoryManager cateMan = new CategoryManager();
            List<Category> cate = cateMan.getCategories(0);
            cateMan.updateCategory(newCate);
            return RedirectToAction("List", "Category", cate);
        }
    }
}
