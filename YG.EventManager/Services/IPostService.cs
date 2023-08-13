using YG.EventManager.Models;

namespace YG.EventManager.Services
{
    public interface IPostService : IYGService
    {
        void Like(string userId, string postId);
        void Create(Post post);
        void Comment(string userId, string postId, string message);
        Task<List<Post>> GetPosts();
        Task<Post> Get(int id);
    }
}
