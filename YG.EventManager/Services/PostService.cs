using YG.EventManager.Models;

namespace YG.EventManager.Services
{
    public class PostService : IPostService
    {
        // _db

        public void Comment(string userId, string postId, string message)
        {
            throw new NotImplementedException();
        }

        public void Create(Post post)
        {
            throw new NotImplementedException();
        }

        public async Task<Post> Get(int id)
        {
            await Task.Delay(100);

            return new Post
            {
                Id = id                
            };
        }

        public async Task<List<Post>> GetPosts()
        {
            await Task.Delay(100);

            throw new NotImplementedException();
        }

        public void Like(string userId, string postId)
        {
            throw new NotImplementedException();
        }
    }
}
