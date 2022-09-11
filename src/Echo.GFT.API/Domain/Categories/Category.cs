namespace Echo.GFT.API.Domain.Categories
{
    public class Category
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public Category(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
