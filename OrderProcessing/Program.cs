

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

IConfiguration _configuration = new ConfigurationBuilder()
                            .AddJsonFile("ocelot.json")
                            .Build();

//builder.Services.AddOcelot(_configuration);

app.MapGet("/", () => "Hello World!");

app.Run();