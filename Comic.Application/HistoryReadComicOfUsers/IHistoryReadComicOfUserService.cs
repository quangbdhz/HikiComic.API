using Comic.ViewModels.ComicStrips;
using Comic.ViewModels.Common;
using Comic.ViewModels.HistoryReadComicOfUsers.HistoryReadComicOfUserRequest;

namespace Comic.Application.HistoryReadComicOfUsers
{
    public interface IHistoryReadComicOfUserService
    {
        Task<PagedResult<ComicStripViewModel>> GetAllPaging(PagingRequestBase request, Guid userId);

        Task<ApiResult<bool>> Update(HistoryReadComicOfUserUpdateRequest request);
    }
}
