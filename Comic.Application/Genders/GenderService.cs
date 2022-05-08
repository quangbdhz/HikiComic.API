using Comic.Data.EF;
using Comic.ViewModels.Common;
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

        public async Task<ApiResult<int>> GetById(int idGender)
        {
            var genders = await _context.Genders.ToListAsync();

            return null;
        }
    }
}
