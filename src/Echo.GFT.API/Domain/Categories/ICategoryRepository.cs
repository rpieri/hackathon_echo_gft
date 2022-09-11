namespace Echo.GFT.API.Domain.Categories
{
    public interface ICategoryRepository
    {
        IList<Category> GetAll();
        Category? GetByName(string name);
    }
}
