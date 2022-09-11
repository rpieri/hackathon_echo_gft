using Echo.GFT.API.Domain.Categories;

namespace Echo.GFT.API.Domain.Profiles
{
    public class Profile
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int NumberOfFollowers { get; private set; }
        public string Region { get; private set; }
        public string Country { get; private set; }
        public string LogoURI { get; private set; }
        public IList<Category> Categories { get; private set; }

        public Profile(string name, int numberOfFollowers, string region, string country, string logoURI)
        {
            Id = Guid.NewGuid();
            Name = name;
            NumberOfFollowers = numberOfFollowers;
            Region = region;
            Country = country;
            LogoURI = logoURI;
            Categories = new List<Category>();
        }
    }
}
