using Comic.Application.DetailComics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class DetailComicsController : ControllerBase
    {
        private readonly IDetailComicService _detailComicService;

        public DetailComicsController(IDetailComicService detailComicService)
        {
            _detailComicService = detailComicService;
        }

        [HttpGet("GetById/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            var detailComic = await _detailComicService.GetById(id);
            return Ok(detailComic);
        }

        [HttpGet("GetById/{id}/{userId}")]
        public async Task<IActionResult> GetById(Guid userId, int id)
        {
            var detailComic = await _detailComicService.GetById(userId, id);
            return Ok(detailComic);
        }

        [HttpGet("GetBySeoAlias/{seoalias}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBySeoAlias(string seoalias)
        {
            var detailComic = await _detailComicService.GetBySeoAlias(seoalias);
            return Ok(detailComic);
        }

        [HttpGet("GetBySeoAlias/{seoalias}/{userId}")]
        public async Task<IActionResult> GetBySeoAlias(Guid userId, string seoalias)
        {
            var detailComic = await _detailComicService.GetBySeoAlias(userId, seoalias);
            return Ok(detailComic);
        }

        [HttpGet("UpdateComicUserFollow/{userId}/{comicId}")]
        public async Task<IActionResult> UpdateComicUserFollow(Guid userId, int comicId)
        {
            var detailComic = await _detailComicService.UpdateUserFollowComic(userId, comicId);
            return Ok(detailComic);
        }
    }
}
