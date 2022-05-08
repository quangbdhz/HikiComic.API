using Comic.Application.ListOfComicsUsersFollows;
using Comic.ViewModels.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ListOfComicsUsersFollowController : ControllerBase
    {
        private readonly IListOfComicsUsersFollowService _listOfComicsUsersFollowService;

        public ListOfComicsUsersFollowController(IListOfComicsUsersFollowService listOfComicsUsersFollowService)
        {
            _listOfComicsUsersFollowService = listOfComicsUsersFollowService;
        }

        [HttpGet("{userid}/paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] PagingRequestBase request, Guid userid)
        {
            var comicFollows = await _listOfComicsUsersFollowService.GetAllPaging(request, userid);
            return Ok(comicFollows);
        }
    }
}
