using Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Logics
{
    public class ProductManager
    {
        PRNProjectContext context;

        public ProductManager()
        {
            context = new PRNProjectContext();
        }

        public List<Product> GetProducts(int brandId)
        {
            context.Products.ToList();
            if (brandId == 0)
            {
                return context.Products.ToList();
            }
            else return context.Products.Where(x => x.BrandId == brandId).ToList();
        }
        public List<Product> GetProducts1(int brandId)
        {
            context.Products.Join(context.Brands,
                    pro => pro.BrandId,
                    bra => bra.Id,
                    (pro, bra) => pro
                    ).ToList();
            if (brandId == 0)
            {
                return context.Products.Join(context.Brands,
                    pro => pro.BrandId,
                    bra => bra.Id,
                    (pro, bra) => pro
                    ).ToList();
            }
            else return context.Products.Where(x => x.BrandId == brandId).ToList();
        }

        public void AddProduct(Product newPro)
        {
            string img = newPro.Image;
            string path = "/img/";
            newPro.Image = path + img;
            context.Products.Add(newPro);
            context.SaveChanges();

        }

        public Product GetProduct(int ProductId)
        {
            return context.Products.FirstOrDefault(x => x.Id == ProductId);
        }

        public Product GetProduct1(int ProductId)
        {
            return context.Products.Join(context.Brands,
                    pro => pro.BrandId,
                    bra => bra.Id,
                    (pro, bra) => pro
                    ).FirstOrDefault(x => x.Id == ProductId);
        }
        public void DeleteProduct(int ProductId)
        {
            Product pro = context.Products.FirstOrDefault(x => x.Id == ProductId);
            context.Products.Remove(pro);
            context.SaveChanges();
        }

        public void UpdateProduct(Product newPro)
        {
            Product oldPro = context.Products.Join(context.Brands,
                    pro => pro.BrandId,
                    bra => bra.Id,
                    (pro, bra) => pro
                    ).FirstOrDefault(x => x.Id == newPro.Id); 
            oldPro.Name = newPro.Name;
            oldPro.Description = newPro.Description;
            oldPro.Price = newPro.Price;
            oldPro.Quantity = newPro.Quantity;
            oldPro.Status = newPro.Status;
            oldPro.BrandId = newPro.BrandId;
            oldPro.Image = "/img/"+ newPro.Image;
            context.SaveChanges();
        }

    }
}
