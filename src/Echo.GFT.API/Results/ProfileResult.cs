using Echo.GFT.API.Domain.Profiles;

namespace Echo.GFT.API.Results
{
    public class ProfileResult
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public int NumberOfFollowers { get; private set; }

        public string Region { get; private set; }

        public string Country { get; private set; }

        public string LogoURI { get; private set; }

        public IList<CategoryResult> Categories { get; private set; }

        public ProfileResult(Profile profile)
        {
            Id = profile.Id;
            Name = profile.Name;   
            NumberOfFollowers = profile.NumberOfFollowers;
            Region = profile.Region;
            Country = profile.Country;
            LogoURI = profile.LogoURI;
            Categories = new List<CategoryResult>();
            profile.Categories.ToList().ForEach(category => Categories.Add(new CategoryResult(category)));
        }
    }
}
