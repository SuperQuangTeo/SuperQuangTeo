using Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project.Logics
{
    public class BrandManager
    {
        PRNProjectContext context;

        public BrandManager()
        {
            context = new PRNProjectContext();
        }
        public List<Brand> getBrands()
        {
            return context.Brands.ToList();
        }

        public List<Brand> getBrands1(int Id)
        {
            context.Brands.ToList();
            if(Id == 0)
            {
                return context.Brands.ToList();
            }
            else return context.Brands.Where(b => b.Id == Id).ToList();
        }

        public Brand getBrand(int Id)
        {
            return context.Brands.FirstOrDefault(b => b.Id == Id);
        }

        public void addBrand(Brand newBrand)
        {
            context.Brands.Add(newBrand);
            context.SaveChanges();
        }

        public void updateBrand(Brand newBrand)
        {
            Brand oldBrand = context.Brands.FirstOrDefault(b => b.Id == newBrand.Id);
            oldBrand.Id = newBrand.Id;
            oldBrand.Name = newBrand.Name;
            oldBrand.Description = newBrand.Description;
            oldBrand.Address = newBrand.Address;
            context.SaveChanges();
        }
    }
}
