using Comic.ViewModels.ComicStrips;
using Comic.ViewModels.Common;

namespace Comic.Application.ListOfComicsUsersFollows
{
    public interface IListOfComicsUsersFollowService
    {
        Task<PagedResult<ComicStripViewModel>> GetAllPaging(PagingRequestBase request, Guid userId);
    }
}
