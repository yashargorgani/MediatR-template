using MediatR;
using YG.EventManager.Notifications.Events;

namespace YG.EventManager.Notifications.Handlers
{
    // using MediatR INotificationHandler directly
    public class PostFetchLogHandler : INotificationHandler<PostFetchNotification>
    {
        public async Task Handle(PostFetchNotification notification, CancellationToken cancellationToken)
        {
            await Task.Delay(1000);

            Console.WriteLine($"Post with id: [{notification?.Post?.Id}] Read");
        }
    }
}
