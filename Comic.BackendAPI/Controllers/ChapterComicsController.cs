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
            var chapterComics = await _chapterComicService.GetByComicId(id);

            if (chapterComics == null)
                return NotFound();

            return Ok(chapterComics);
        }

        [HttpGet("GetBySeoAlias/{seoAlias}")]
        public async Task<IActionResult> GetBySeoAlias(string seoAlias)
        {
            var chapterComics = await _chapterComicService.GetByComicSeoAlias(seoAlias); 

            if (chapterComics == null)
                return NotFound();

            return Ok(chapterComics);
        }

        [HttpPatch("AddViewCount/{seoAliasChapter}")]
        public async Task<IActionResult> AddViewCount(string seoAliasChapter)
        {
            var chapterComic = await _chapterComicService.AddViewCount(seoAliasChapter);

            if (chapterComic == null)
                return NotFound();

            return Ok(chapterComic);
        }
    }
}
