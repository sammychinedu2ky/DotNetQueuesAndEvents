using System.Threading.Channels;

namespace UsingBackgroundQueues.LongRunning
{
    public class BackgroundHost : BackgroundService
    {
        private readonly Channel<int> _queue;
        public BackgroundHost(BackgroundQueue queue)
        {
            _queue = queue.Queue;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            //await foreach (var userId in _queue.Reader.ReadAllAsync())
            //{
            //    await Task.Delay(4000);
            //    Console.WriteLine($"The userid == {userId} just got a mail");
            //}
            while (await _queue.Reader.WaitToReadAsync(stoppingToken))
            {
                if(_queue.Reader.TryPeek(out var userId))
                {
                    await Task.Delay(1000);
                    Console.WriteLine($"The userid == {userId} just got a mail");
                    _queue.Reader.TryRead(out _);
                }
            }
          

            return;
        }
      
    }
}
