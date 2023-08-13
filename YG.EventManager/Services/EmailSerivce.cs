using YG.EventManager.Models;

namespace YG.EventManager.Services
{
    public class EmailSerivce : IEmailService
    {
        public async Task SendEmail(Email email)
        {
            await Task.Delay(500);

            Console.WriteLine("Post email sent to: " + email.To);
        }
    }
}
