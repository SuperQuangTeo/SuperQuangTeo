using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Logics
{
    public class CategoryManager
    {
        PRNProjectContext context;

        public CategoryManager()
        {
            context = new PRNProjectContext();
        }

        public List<Category> getCategories(int Id)
        {
            context.Categories.ToList();
            if (Id == 0)
            {
                return context.Categories.ToList();
            }
            else return context.Categories.Where(c => c.Id == Id).ToList();
        }

        public List<Category> getCategories1(int Id)
        {
            return context.Categories.ToList();
        }

        public void addCategory(Category newCate)
        {
            context.Categories.Add(newCate);
            context.SaveChanges();
        }

        public Category GetCategory(int Id)
        {
            return context.Categories.FirstOrDefault(c => c.Id == Id);
        }

        public void removeCategory(int Id)
        {
            Category category = context.Categories.FirstOrDefault(c => c.Id == Id);
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public void updateCategory(Category newCate)
        {
            Category oldCate = context.Categories.FirstOrDefault(c => c.Id == newCate.Id);             
            oldCate.Name = newCate.Name;
            oldCate.Description = newCate.Description;
            oldCate.Type = newCate.Type;
            context.SaveChanges();
        }
    }
}
