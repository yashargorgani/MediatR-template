using YG.EventManager.Models;

namespace YG.EventManager.Services
{
    public interface IEmailService : IYGService
    {
        Task SendEmail(Email email);
    }
}
