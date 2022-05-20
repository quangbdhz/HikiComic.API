using Comic.Application.Genders;
using Microsoft.AspNetCore.Mvc;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        private readonly IGenderService _genderService;

        public GendersController(IGenderService genderService)
        {
            _genderService = genderService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var genders = await _genderService.GetAll();
            return Ok(genders);
        }

        [HttpGet("GetById/{idGender}")]
        public async Task<IActionResult> GetById(int idGender)
        {
            var gender = await _genderService.GetById(idGender);
            return Ok(gender);
        }
    }
}
