using SOLID.DIP.After;
using System.Security.Cryptography;

namespace SOLID.DIP
{
    class Program
    {
        public static void Main(string[] args)
        {
            var customers = After.Repository.Customers;
            foreach (var customer in customers)
            {
                var messageService = new List<IMessageService>
                {
                    new After.EmailService{EmailAddress = customer.EmailAddress },
                    new After.SMSService{MobileNo = customer.MobileNo },
                };


                #region Constructor Injection
                //  var notificationService = new After.NotificationService(messageService);
                // notificationService.Notify(); 
                #endregion


                
                #region Property Injection
                //var notificationService1 = new After.NotificationService1();
                //notificationService1.messages = messageService;
                //notificationService1.Notify();
                #endregion

                 
                #region Method Injection
                var notificationService2 = new After.NotificationService2();
                notificationService2.Notify(messageService);
                #endregion

            }
        }
    }
}