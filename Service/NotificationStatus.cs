using WebApplicationExam2023.ViewModel;   
using WebApplicationExam2023.Controllers;

    namespace WebApplicationExam2023.Service;


    public class NotificationStatus
    {
        public void Notify(string text)
        {
            Console.WriteLine($"Notification: {text}");
        }

    }

