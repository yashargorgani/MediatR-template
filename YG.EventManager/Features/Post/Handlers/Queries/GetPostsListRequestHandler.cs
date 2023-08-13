using MediatR;
using YG.EventManager.Features.Post.Requests.Queries;
using YG.EventManager.Models;
using YG.EventManager.Services;

namespace YG.EventManager.Features.Post.Handlers.Queries
{
    public class GetPostsListRequestHandler : IRequestHandler<GetPostsListRequest, List<Models.Post>>
    {
        private readonly IPostService _postService;

        public GetPostsListRequestHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<List<Models.Post>> Handle(GetPostsListRequest request, CancellationToken cancellationToken)
        {
            return await _postService.GetPosts();
        }
    }
}
