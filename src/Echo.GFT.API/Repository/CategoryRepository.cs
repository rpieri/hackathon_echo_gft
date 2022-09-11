using Echo.GFT.API.Domain.Categories;

namespace Echo.GFT.API.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IList<Category> categories;

        public CategoryRepository()
        {
            categories = new List<Category>();
            LoadCategory();
        }

        public IList<Category> GetAll() => categories;
        public Category? GetByName(string name) => categories.ToList().FirstOrDefault(x => x.Name.Equals(name));

        private void LoadCategory()
        {
            categories.Add(new Category("Developer"));
            categories.Add(new Category(".NET"));
            categories.Add(new Category("JAVA"));
            categories.Add(new Category("FrontEnd"));
            categories.Add(new Category("Mobile"));
            categories.Add(new Category("Blockchain"));
        }
    }
}
