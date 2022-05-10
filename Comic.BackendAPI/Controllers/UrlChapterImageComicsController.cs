using Comic.Application.UrlChapterImageComics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrlChapterImageComicsController : ControllerBase
    {
        private readonly IUrlChapterImageComicService _urlChapterImageComicService;

        public UrlChapterImageComicsController(IUrlChapterImageComicService urlChapterImageComicService)
        {
            _urlChapterImageComicService = urlChapterImageComicService;
        }

        [HttpGet("GetByChapterComicId/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var urlImageComics = await _urlChapterImageComicService.GetByChapterComicId(id);

            if (urlImageComics == null)
                return NotFound();

            return Ok(urlImageComics);
        }

        [HttpGet("GetByChapterComicSeoAlias/{seoAlias}")]
        public async Task<IActionResult> GetBySeoAlias(string seoAlias)
        {
            var urlImageComics = await _urlChapterImageComicService.GetByChapterComicSeoAlias(seoAlias);

            if (urlImageComics == null)
                return NotFound();

            return Ok(urlImageComics);
        }

    }
}
