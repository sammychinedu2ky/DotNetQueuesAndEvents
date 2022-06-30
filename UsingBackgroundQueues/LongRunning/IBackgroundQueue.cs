namespace UsingBackgroundQueues.LongRunning
{
    public interface IBackgroundQueue
    {
        void SendMail(int userId);
    }
}