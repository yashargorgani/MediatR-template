using MediatR;

namespace YG.EventManager.Notifications
{
    public abstract class NotificationBaseHandler<T> : INotificationHandler<T> where T : INotification
    {
        public abstract bool CanHandle(T notification);
        public abstract Task RunHandler(T notification, CancellationToken cancellationToken);

        public Task Handle(T notification, CancellationToken cancellationToken)
        {
            if (CanHandle(notification))
                return RunHandler(notification, cancellationToken);

            return Task.CompletedTask;
        }
    }
}
