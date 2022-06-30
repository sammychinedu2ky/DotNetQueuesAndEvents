namespace UsingEvents.LongRunning
{
    public class BackgroundRunner : BackgroundService
    {
        public IPublisher _publisher;
        public BackgroundRunner(IPublisher publisher) {
           _publisher = publisher;
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
         
            _publisher.OnPublish += HandleEvent;
                Console.WriteLine("hello world I'm a background service");
               // Task.Delay(4000).Wait();
            
            return Task.CompletedTask;
        }
        public async void HandleEvent(object? sender, int userId)
        {
           await Task.Delay(10000);
            Console.WriteLine($"The userid == {userId} just got a mail");
        }
    }
}
