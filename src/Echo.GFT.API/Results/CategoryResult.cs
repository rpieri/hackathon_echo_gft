using Echo.GFT.API.Domain.Categories;

namespace Echo.GFT.API.Results
{
    public class CategoryResult
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public CategoryResult(Category category)
        {
            Id = category.Id;
            Name = category.Name;
        }
    }
}
