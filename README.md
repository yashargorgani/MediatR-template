<p>
  This is a simple project to learn and examine MediatR capabilities.
</p>

<p>
  <h4>'Features' folder (CQRS)</h4>
  In 'Features' folder, you see some requests and their handlers. These requests use MediatR <i>IRequest</i> and <i>IRequestHandler</i> implementations. This is a good method for CQRS pattern. 
  <b>
      Each request can only have <i>ONE</i> Handler.
  </b>
</p>
<p>
  <h4>'Notifications' folder, multiple handlers</h4>
  For having multiple handlers for one request, MediatR <i>INotification</i> was used. In 'Notifications' folder you see one Notification and two notification handlers. (I know senarios such as liking or commenting a post, or even creating a post could be more understandable)
</p>
<p>
  Each handler calls a specific service method and write an Action on console, you can see both handlers write their line.
</p>
<p>
  <h4>'NotificationBaseHandler' abstract class</h4>
  For more abstraction, an abstract class called 'NotificationBaseHandler' has implemented, so we can have our own level of abstraction. This abstract class, has an abstract method called 'CanHandle' that verifies that the handler can be executed or not. Another abstract method is called 'RunHandler' with arguments exactly like Handle method. The INotificationHandler Handle method is implemented in this abstract class, inside that, first it calls 'CanHandle' method and if it returns 'true', it calls 'RunHandler'.
</p>
