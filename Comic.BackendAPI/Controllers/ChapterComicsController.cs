using Comic.Application.ChapterComics;
using Microsoft.AspNetCore.Mvc;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterComicsController : ControllerBase
    {
        private readonly IChapterComicService _chapterComicService;

        public ChapterComicsController(IChapterComicService chapterComicService)
        {
            _chapterComicService = chapterComicService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var chapterComics = await _chapterComicService.GetById(id);
            return Ok(chapterComics);
        }

        [HttpGet("GetBySeoAlias/{seoAlias}")]
        public async Task<IActionResult> GetBySeoAlias(string seoAlias)
        {
            var chapterComics = await _chapterComicService.GetBySeoAlias(seoAlias);
            return Ok(chapterComics);
        }

    }
}
