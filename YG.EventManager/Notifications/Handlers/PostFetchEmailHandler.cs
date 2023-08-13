using MediatR;
using YG.EventManager.Notifications.Events;
using YG.EventManager.Services;

namespace YG.EventManager.Notifications.Handlers
{
    // using our abstract class of NotificationBaseHandler
    public class PostFetchEmailHandler : NotificationBaseHandler<PostFetchNotification>
    {
        private readonly IEmailService _emailService;
        public PostFetchEmailHandler(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public override bool CanHandle(PostFetchNotification notification)
        {
            return notification.Post != null;
        }

        public override async Task RunHandler(PostFetchNotification notification, CancellationToken cancellationToken)
        {
            await _emailService.SendEmail(new Models.Email
            {
                To = "yashargorgani@gmail.com"
            });
        }
    }
}
