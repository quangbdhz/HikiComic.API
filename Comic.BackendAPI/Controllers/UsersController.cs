using Comic.Application.MailConfirms;
using Comic.Application.Users;
using Comic.Utilities.Constants;
using Comic.ViewModels.Common;
using Comic.ViewModels.MailConfirms;
using Comic.ViewModels.Users;
using Comic.ViewModels.Users.UserDataRequest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMailConfirmService _emailConfirmService;

        public UsersController(IUserService userService, IMailConfirmService emailConfirmService)
        {
            _userService = userService;
            _emailConfirmService = emailConfirmService;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Authencate(request);

            if (string.IsNullOrEmpty(result.ResultObj))
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var user = await _userService.GetById(id);
            return Ok(user);
        }

        [HttpGet("GetByEmail/{email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            email = WebUtility.UrlDecode(email);
            var user = await _userService.GetByEmail(email);
            return Ok(user);
        }

        [HttpPost("Register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Register(request);

            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }

            MailConfirmViewModel mailConfirmViewModel = this.GetMailObject(result.ResultObj);
            await _emailConfirmService.SendMail(mailConfirmViewModel);

            return Ok(new { Message = MessageConstants.VerifyMail });
        }   

        [NonAction]
        public MailConfirmViewModel GetMailObject(UserViewModel userViewModel)
        {
            MailConfirmViewModel mailConfirmViewModel = new MailConfirmViewModel();
            mailConfirmViewModel.Subject = "Mail Confirmation";
            mailConfirmViewModel.Body = _emailConfirmService.GetMailBody(userViewModel);
            mailConfirmViewModel.ToMailIds = new List<string>()
            {
                userViewModel.Email
            };
            return mailConfirmViewModel;
        }

        [HttpPost("ConfirmMail")]
        [AllowAnonymous]
        public async Task<ApiResult<bool>> ConfirmMail(string userName)
        {
            var result = await _userService.ConfirmMail(userName);
            return result;
        }
    }
}
