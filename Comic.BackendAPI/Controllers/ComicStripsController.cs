using Comic.Application.ComicStrips;
using Comic.ViewModels.ComicStrips.ComicStripRequest;
using Comic.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicStripsController : ControllerBase
    {
        private readonly IComicStripService _comicStripService;

        public ComicStripsController(IComicStripService comicStripService)
        {
            _comicStripService = comicStripService;
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] ComicStripPagingRequest request)
        {
            var comicStrips = await _comicStripService.GetAllPaging(request);
            return Ok(comicStrips);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<ApiResult<bool>> Create([FromForm] ComicStripCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return new ApiErrorResult<bool>("IsValid");
            }

            var comicStripId = await _comicStripService.Create(request);

            if (comicStripId != 0)
            {
                return new ApiSuccessResult<bool>();
            }

            return new ApiErrorResult<bool>("Error");
        }

        [HttpPatch("{comicStripId}")]
        public async Task<ApiResult<bool>> AddViewCount(int comicStripId)
        {
            if (!ModelState.IsValid)
            {
                return new ApiErrorResult<bool>("IsValid");
            }

            var output = await _comicStripService.AddViewcount(comicStripId);

            if (output == 0)
                return new ApiErrorResult<bool>("Error");

            return new ApiSuccessResult<bool>();

        }

        [HttpPost("{comicStripId}/{rating}")]
        public async Task<ApiResult<bool>> AddRatingComic(int comicStripId, double rating)
        {
            if (!ModelState.IsValid)
            {
                return new ApiErrorResult<bool>("IsValid");
            }

            return await _comicStripService.AddRating(comicStripId, rating);
        }

        [HttpDelete("{comicStripId}")]
        public async Task<ApiResult<bool>> DeleteComicStrip(int comicStripId)
        {
            if (!ModelState.IsValid)
            {
                return new ApiErrorResult<bool>("IsValid");
            }

            return await _comicStripService.Delete(comicStripId);
        }

        [HttpGet("NewComicPaging")]
        public async Task<IActionResult> GetNewComicPaging([FromQuery] PagingRequestBase request)
        {
            var comicStrips = await _comicStripService.GetNewComicPaging(request);
            return Ok(comicStrips);
        }

        [HttpGet("HotComicPaging")]
        public async Task<IActionResult> GetHotComicPaging()
        {
            var comicStrips = await _comicStripService.GetHotComicPaging();
            return Ok(comicStrips);
        }
    }
}
