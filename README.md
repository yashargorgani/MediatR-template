# YG.EventManager

<p>
  This is a simple project to learn and examin MediatR capabilities.
</p>
<p>
  In 'Features' folder, you see some requests and their handlers. These requests use MediatR <i>IRequest</i> and <i>IRequestHandler</i> implementations. This is a good method for CQRS pattern. 
  <b>
      Each request can only have <i>ONE</i> Handler.
  </b>
</p>
<p>
  For having multiple handlers for one request, MediatR INotification was used. In 'Notifications' folder you see one Notification and two notification handlers. (I know senarios such as liking or commenting a post, or even creating a post could be more understandable)
</p>
<p>
  Each handler calls a specific service method and write an Action on console, you can see both handlers write their line.
</p>
<p>
  For more abstraction, an abstract class called 'NotificationBaseHandler' has implemented, so we can have our own level of abstraction. This abstract class, has an abstract method called 'CanHandle' that verifies that the handler can be executed or not. Another abstract method is called 'RunHandler' with arguments exactly like Handle method. The INotificationHandler Handle method is implemented in this abstract class, inside that, first it calls 'CanHandle' method and if it returns 'true', it calls 'RunHandler'.
</p>
