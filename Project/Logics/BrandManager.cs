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
        public List<Brand> getBrand()
        {
            return context.Brands.ToList();
        }

    }
}
