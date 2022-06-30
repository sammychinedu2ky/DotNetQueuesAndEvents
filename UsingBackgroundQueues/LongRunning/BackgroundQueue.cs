using System.Threading.Channels;
namespace UsingBackgroundQueues.LongRunning
{
    public class BackgroundQueue : IBackgroundQueue
    {
        public readonly Channel<int> Queue;

        public BackgroundQueue()
        {
            Queue = Channel.CreateUnbounded<int>();
        }
        public void SendMail(int userId)
        {



        }
    }
}
