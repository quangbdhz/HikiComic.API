using Comic.ViewModels.ComicStrips;
using Comic.ViewModels.ComicStrips.ComicStripRequest;
using Comic.ViewModels.Common;

namespace Comic.Application.ComicStrips
{
    public interface IComicStripService
    {
        Task<int> Create(ComicStripCreateRequest request);

        Task<int> Update(ComicStripUpdateRequest request);

        Task<ApiResult<bool>> Delete(int comicStripId);

        Task<PagedResult<ComicStripViewModel>> GetAllPaging(ComicStripPagingRequest request);

        Task<int> AddViewcount(int comicStripId);

        Task<ApiResult<bool>> AddRating(int comicStripId, double rating);

        Task<List<ComicStripViewModel>> GetNewComicPaging();

        Task<List<ComicStripViewModel>> GetHotComicPaging();
    }
}
