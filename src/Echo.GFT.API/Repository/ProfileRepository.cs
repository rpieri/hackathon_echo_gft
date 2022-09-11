using Echo.GFT.API.Domain.Categories;
using Echo.GFT.API.Domain.Profiles;

namespace Echo.GFT.API.Repository
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly IList<Profile> profiles;
        private readonly ICategoryRepository categoryRepository;

        public ProfileRepository(ICategoryRepository categoryRepository)
        {
            profiles = new List<Profile>();
            this.categoryRepository = categoryRepository;
            LoadProfiles();            
        }

        public IList<Profile> GetAll() => profiles;

        private void LoadProfiles()
        {            
            profiles.Add(NewProfile("Academind", 820000, "Europe", "Germany", "https://yt3.ggpht.com/ytc/AMLnZu_Uksjq0hZKO8HU1hqf8LTFE91m1CeiSOe__5L8BA=s176-c-k-c0x00ffffff-no-rj", GetCategory("Developer"), GetCategory("FrontEnd")));
            profiles.Add(NewProfile("Fluterando",50000, "South America", "Brazil", "https://yt3.ggpht.com/ytc/AMLnZu__bQ9RVO05hk_eABnlA8kTMVFD8fY7P4arnpDx=s176-c-k-c0x00ffffff-no-rj", GetCategory("Developer"), GetCategory("Mobile")));
            profiles.Add(NewProfile("Dapp University", 536000, "North America", "USA", "https://yt3.ggpht.com/ytc/AMLnZu-hwnFyGerAS54ruKbpweE95tWlA9l7EntU5K3v=s176-c-k-c0x00ffffff-no-rj", GetCategory("Developer"), GetCategory("Blockchain")));
            profiles.Add(NewProfile("Ana Beatriz Neri", 60000, "South America", "Brazil", "https://yt3.ggpht.com/ytc/AMLnZu_Uksjq0hZKO8HU1hqf8LTFE91m1CeiSOe__5L8BA=s176-c-k-c0x00ffffff-no-rj", GetCategory("Developer"), GetCategory("JAVA")));
            profiles.Add(NewProfile("Eduardo Pires", 13900, "South America", "Brazil", "https://yt3.ggpht.com/ytc/AMLnZu-O3f0l9x2_Yd05TlVgZCpzFdMf-Q3BG2GwlUtGsA=s176-c-k-c0x00ffffff-no-rj", GetCategory("Developer"), GetCategory(".NET")));
            profiles.Add(NewProfile("Balta.IO", 54900, "South America", "Brazil", "https://yt3.ggpht.com/ytc/AMLnZu_1XFfRS92xyFtPULZbRTo6vKmB-sOntUnCgodMxg=s176-c-k-c0x00ffffff-no-rj", GetCategory("Developer"), GetCategory(".NET"), GetCategory("FrontEnd")));
        }

        private Profile NewProfile(string name, int numberOfFollowers, string region, string country, string logoURI, params Category[] categories)
        {
            var profile = new Profile(name, numberOfFollowers, region, country, logoURI);
            categories.ToList().ForEach(c => profile.Categories.Add(c));
            return profile;
        }

        private Category GetCategory(string name)
        {
            var category = categoryRepository.GetByName(name);
            return category ?? new Category($"Not found this category {name}");
        }
    }
}
