using Comic.Application.DetailComics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailComicsController : ControllerBase
    {
        private readonly IDetailComicService _detailComicService;

        public DetailComicsController(IDetailComicService detailComicService)
        {
            _detailComicService = detailComicService;
        }

        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var detailComic = await _detailComicService.GetById(id);
            return Ok(detailComic);
        }

        [HttpGet("getbyseoalias/{seoalias}")]
        public async Task<IActionResult> GetById(string seoalias)
        {
            var detailComic = await _detailComicService.GetBySeoAlias(seoalias);
            return Ok(detailComic);
        }


    }
}
