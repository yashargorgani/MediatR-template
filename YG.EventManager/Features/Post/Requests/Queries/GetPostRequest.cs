using MediatR;

namespace YG.EventManager.Features.Post.Requests.Queries
{
    public class GetPostRequest : IRequest<YG.EventManager.Models.Post>
    {
        public int Id { get; set; }
    }
}
