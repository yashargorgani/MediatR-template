using MediatR;
using YG.EventManager.Models;

namespace YG.EventManager.Features.Post.Requests.Queries
{
    public class GetPostsListRequest : IRequest<List<Models.Post>>
    {
    }
}
