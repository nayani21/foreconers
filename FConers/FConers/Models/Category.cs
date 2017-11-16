using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FConers.Models
{
   public class Category
    {

        public int Id { get; set; }
        public String CategoryName { get; set; }
        public String Color { get; set; }
        public String Image { get; set; }
    }
    public static class CategoryFactory

    {
        public static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    Id=0,
                    CategoryName="Science",
                    Color="#F5D0A9",
                    Image="twilight.jpg"
                },
                 new Category
                {
                    Id=1,
                    CategoryName="History",
                    Color="#FFFF00",
                    Image="walktoremember.jpg"
                },
                  new Category
                {
                    Id=2,
                    CategoryName="Biyography",
                    Color="#FE2EC8",
                     Image="twilight.jpg"
                },
                   new Category
                {
                    Id=3,
                    CategoryName="Diet,Health",
                    Color="#4B088A",
                    Image="walktoremember.jpg"
                }
            };
            return categories;
        }
    }
}
