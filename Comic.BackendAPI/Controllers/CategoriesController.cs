using Comic.Application.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Comic.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAll();
            return Ok(categories);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetById(id);
            return Ok(category);
        }

        [HttpGet("GetBySeoAlias/{seoAlias}")]
        public async Task<IActionResult> GetBySeoAlias(string seoAlias)
        {
            var category = await _categoryService.GetBySeoAlias(seoAlias);
            return Ok(category);
        }

        [HttpGet("IsShowHome")]
        public async Task<IActionResult> GetIsShowHome()
        {
            var categories = await _categoryService.GetCategoryShowHome();
            return Ok(categories);
        }

        [HttpGet("GetBySize/{number}")]
        public async Task<IActionResult> GetBySize(int number)
        {
            var categories = await _categoryService.GetBySize(number);
            return Ok(categories);
        }
    }
}
