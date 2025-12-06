var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var githubUrl = "https://github.com/SinmisolaE/basic-app-ci-cd";

app.MapGet("/info", () =>
{
    return new
    {
        Date = DateTime.UtcNow,
        LuckyNumber = Random.Shared.Next(0, 100),
        GithubUrl = githubUrl
    };
});


app.Run();

