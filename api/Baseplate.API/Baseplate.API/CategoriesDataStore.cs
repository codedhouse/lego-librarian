using Baseplate.API.Models;

namespace Baseplate.API
{
    public class CategoriesDataStore
    {
        public List<CategoryDto> Categories { get; set; }

        public static CategoriesDataStore Current { get; } = new CategoriesDataStore();

        public CategoriesDataStore()
        {
            // init dummy data
            Categories = new List<CategoryDto>()
            {
                new CategoryDto() { Id = 1, Name="brick"},
                new CategoryDto() { Id = 2, Name="plate"},
                new CategoryDto() { Id = 3, Name="tile"},
                new CategoryDto() { Id = 4, Name="slope"},
                new CategoryDto() { Id = 5, Name="animal"},
            };
        }
    }
}
