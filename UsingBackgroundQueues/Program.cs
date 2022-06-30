using System.Threading.Channels;
using UsingBackgroundQueues.LongRunning;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<BackgroundQueue>();
builder.Services.AddHostedService<BackgroundHost>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
