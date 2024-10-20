
using Microsoft.AspNet.SignalR;
//using sagenoti1.Models;
//using sagenoti1.Hubs;

namespace sagenoti1.Models
{
    public class NotificationHub : Hub
    {
        public void sendMessage(int id)
        {
            // Get the notification count
            //int notificationCount = GetNotificationCount();

            // Get a referenceto the NotificationHub
            //int c = db.reports.where(async =? async.activate == true && async.confirm == false).tolist().count();
            IHubContext notificationHub = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();

            // Call the updateNotificationCounter method on all clients
            notificationHub.Clients.All.updateNotificationCounter(id);
        }

        //private int GetNotificationCount()
        //{
        //    // Get the notification count from your data source
        //    // For example, you could query a database table or call a Web API endpoint

        //    return 10; // Return a hardcoded value for demonstration purposes
        //}
    }
}