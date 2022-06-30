
namespace UsingEvents.LongRunning
{
    public interface IPublisher
    {
        event EventHandler<int>? OnPublish;

        void SendMail(int userId);
    }
}