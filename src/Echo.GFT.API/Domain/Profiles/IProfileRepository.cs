namespace Echo.GFT.API.Domain.Profiles
{
    public interface IProfileRepository
    {
        IList<Profile> GetAll();
    }
}
