using Comic.Application.Categories;
using Comic.ViewModels.Categories.CategoryDataRequest;
using Comic.ViewModels.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAll();
            return Ok(categories);
        }

        [HttpGet("GetById/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetById(id);

            if (category == null)
                return NotFound();

            return Ok(category);
        }

        [HttpGet("GetBySeoAlias/{seoAlias}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBySeoAlias(string seoAlias)
        {
            var category = await _categoryService.GetBySeoAlias(seoAlias);

            if (category == null)
                return NotFound();

            return Ok(category);
        }

        [HttpGet("IsShowHome")]
        [AllowAnonymous]
        public async Task<IActionResult> GetIsShowHome()
        {
            var categories = await _categoryService.GetCategoryShowHome();
            return Ok(categories);
        }

        [HttpGet("GetBySize/{number}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBySize(int number)
        {
            var categories = await _categoryService.GetBySize(number);
            return Ok(categories);
        }

        [HttpPost("Add")]
        public async Task<ApiResult<bool>> AddCategrory([FromBody] AddCategoryRequest request)
        {
            if (!ModelState.IsValid)
                return new ApiErrorResult<bool>("ModelState IsValid");

            return await _categoryService.AddCategrory(request);
        }

        [HttpPost("Update")]
        public async Task<ApiResult<bool>> UpdateCategory([FromBody] UpdateCategoryRequest request)
        {
            if (!ModelState.IsValid)
                return new ApiErrorResult<bool>("ModelState IsValid");

            return await _categoryService.UpdateCategory(request);
        }

        [HttpDelete("Delete/{categoryId}")]
        public async Task<ApiResult<bool>> DeleteCategory(int categoryId)
        {
            return await _categoryService.DeleteCategory(categoryId);
        }

        [HttpGet("PagingManager")]
        public async Task<IActionResult> GetNewComicPaging([FromQuery] PagingRequestBase request)
        {
            var categories = await _categoryService.GetAllPagingManager(request);
            return Ok(categories);
        }
    }
}
