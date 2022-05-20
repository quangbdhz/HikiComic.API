using Comic.Application.ComicStrips;
using Comic.ViewModels.ComicStrips.ComicStripRequest;
using Comic.ViewModels.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ComicStripsController : ControllerBase
    {
        private readonly IComicStripService _comicStripService;

        public ComicStripsController(IComicStripService comicStripService)
        {
            _comicStripService = comicStripService;
        }

        [HttpGet("Paging")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPaging([FromQuery] ComicStripPagingRequest request)
        {
            var comicStrips = await _comicStripService.GetAllPaging(request);
            return Ok(comicStrips);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        [AllowAnonymous]
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

        [HttpPatch("AddViewCount/{comicStripId}")]
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
        [AllowAnonymous]
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

        [HttpPost("Update")]
        [AllowAnonymous]
        public async Task<IActionResult> Update([FromForm] ComicStripUpdateRequest request)
        {
            var comicStrips = await _comicStripService.Update(request);
            return Ok(comicStrips);
        }

        [HttpGet("PagingManager")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPagingManager([FromQuery] ComicStripPagingRequest request)
        {
            var comicStrips = await _comicStripService.GetAllPagingManager(request);
            return Ok(comicStrips);
        }

    }
}
