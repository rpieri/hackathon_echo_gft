using Echo.GFT.API.Domain.Profiles;
using Echo.GFT.API.Results;
using Microsoft.AspNetCore.Mvc;

namespace Echo.GFT.API.Controllers
{
    [Route("api/profiles")]
    public class ProfileController : Controller
    {
        private readonly IProfileRepository repository;

        public ProfileController(IProfileRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = repository.GetAll().Select(profile => new ProfileResult(profile));

            return Ok(new APIResult(true, result, ""));
        }
    }
}
