using Comic.Data.EF;
using Comic.ViewModels.Common;
using Comic.ViewModels.Genders;
using Microsoft.EntityFrameworkCore;

namespace Comic.Application.Genders
{
    public class GenderService : IGenderService
    {
        private readonly ComicDbContext _context;

        public GenderService(ComicDbContext context)
        {
            _context = context;
        }

        public async Task<List<GenderViewModel>> GetAll()
        {
            var query = from g in _context.Genders select new { g };

            return await query.Select(x => new GenderViewModel() { Id = x.g.Id, Name = x.g.NameGender }).ToListAsync();
        }

        public async Task<ApiResult<GenderViewModel>> GetById(int idGender)
        {
            var gender = await _context.Genders.SingleOrDefaultAsync(x => x.Id == idGender);

            if(gender != null)
            {
                GenderViewModel genderViewModel = new GenderViewModel() { Id = gender.Id, Name = gender.NameGender };
                return new ApiSuccessResult<GenderViewModel>() { ResultObj = genderViewModel };
            }
            return new ApiErrorResult<GenderViewModel>();
        }


    }
}
