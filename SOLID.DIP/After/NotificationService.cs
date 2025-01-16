 
namespace SOLID.DIP.After
{
    internal class NotificationService
    {
      
        public readonly List<IMessageService> messages;
        public NotificationService(List<IMessageService> messages)
        {
           this.messages = messages;
        }
        public void Notify()
        {
            foreach (var message in messages) 
            {
                message.Send();
            }
        }
    }internal class NotificationService2
    {
       public List<IMessageService> messages { get;private set; } = new();

        public void setServices(List<IMessageService> messages)
        {
            this.messages = messages;
        }
        public void Notify(List<IMessageService> messages)
        {
            foreach (var message in messages) 
            {
                message.Send();
            }
        }
    }
    internal class NotificationService1
    {
      
        public List<IMessageService> messages { get; set; } = new();
       
        public void Notify()
        {
            foreach (var message in messages) 
            {
                message.Send();
            }
        }
    }
}
