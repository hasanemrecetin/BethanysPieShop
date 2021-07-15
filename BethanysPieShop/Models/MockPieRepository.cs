using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie{PieId = 1,Name="Strawberry Pie",Price=15.95M, ShortDescription="Lorem Ipsum",LongDescription="Blabla",Category = _categoryRepository.AllCategories.Where(x=>x.CategoryId == 1).FirstOrDefault()},
                new Pie{PieId = 2,Name="Cheese cake",Price=18.95M, ShortDescription="Lorem Ipsum",LongDescription="Blabla",Category = _categoryRepository.AllCategories.Where(x=>x.CategoryId == 2).FirstOrDefault()},
                new Pie{PieId = 3,Name="Rhubarb Pie",Price=15.95M, ShortDescription="Lorem Ipsum",LongDescription="Blabla",Category = _categoryRepository.AllCategories.Where(x=>x.CategoryId == 3).FirstOrDefault()},
                new Pie{PieId = 3,Name="Pumpkin Pie",Price=12.95M, ShortDescription="Lorem Ipsum",LongDescription="Blabla",Category = _categoryRepository.AllCategories.Where(x=>x.CategoryId == 5).FirstOrDefault()}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
