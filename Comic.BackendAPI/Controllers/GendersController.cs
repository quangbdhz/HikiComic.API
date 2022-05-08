using Comic.Application.Genders;
using Comic.Data.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        private readonly IGenderService _genderService;

        private readonly ComicDbContext _context;

        public GendersController(IGenderService genderService, ComicDbContext context)
        {
            _genderService = genderService;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int idGender)
        {
            var genders = await _genderService.GetById(idGender);
            return Ok(genders);
        }
    }
}
