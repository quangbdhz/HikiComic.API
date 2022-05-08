using Comic.Application.HistoryReadComicOfUsers;
using Comic.ViewModels.Common;
using Comic.ViewModels.HistoryReadComicOfUsers.HistoryReadComicOfUserRequest;
using Microsoft.AspNetCore.Mvc;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryReadComicOfUsersController : ControllerBase
    {
        private readonly IHistoryReadComicOfUserService _historyReadComicOfUserService;

        public HistoryReadComicOfUsersController(IHistoryReadComicOfUserService historyReadComicOfUserService)
        {
            _historyReadComicOfUserService = historyReadComicOfUserService;
        }

        [HttpGet("{userid}/paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] PagingRequestBase request, Guid userid)
        {
            var historuRead = await _historyReadComicOfUserService.GetAllPaging(request, userid);
            return Ok(historuRead);
        }

        [HttpPost("update")]
        public async Task<ApiResult<bool>> Update([FromQuery] HistoryReadComicOfUserUpdateRequest request)
        {
            var update = await _historyReadComicOfUserService.Update(request);

            return update;
        }
    }
}
