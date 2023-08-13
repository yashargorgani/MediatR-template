using MediatR;

namespace YG.EventManager.Notifications.Events
{
    public class PostFetchNotification : INotification
    {
        public Models.Post? Post { get; set; }
    }
}
