using MediatR;
using YG.EventManager.Features.Post.Requests.Queries;
using YG.EventManager.Services;

namespace YG.EventManager.Features.Post.Handlers.Queries
{
    public class GetPostRequestHandlers : IRequestHandler<GetPostRequest, YG.EventManager.Models.Post>
    {
        private readonly IPostService _postService;
        private readonly IMediator _mediator;
        public GetPostRequestHandlers(IPostService postService, IMediator mediator)
        {
            _postService = postService;
            _mediator = mediator;
        }

        public async Task<Models.Post> Handle(GetPostRequest request, CancellationToken cancellationToken)
        {
            var post = await _postService.Get(request.Id);

            await _mediator.Publish(new Notifications.Events.PostFetchNotification
            {
                Post = post
            });

            return post;
        }
    }
}
