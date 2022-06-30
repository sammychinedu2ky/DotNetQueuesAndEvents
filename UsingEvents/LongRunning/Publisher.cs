namespace UsingEvents.LongRunning
{
    public class Publisher : IPublisher
    {
        public event EventHandler<int>? OnPublish;

        public  void SendMail(int userId)
        {

            OnPublish?.Invoke(this, userId);
            
        }
    }
}
