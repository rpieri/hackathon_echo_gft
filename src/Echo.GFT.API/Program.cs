using Echo.GFT.API.Domain.Categories;
using Echo.GFT.API.Domain.Profiles;
using Echo.GFT.API.Repository;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddNewtonsoftJson();

builder.Services.AddCors(c =>
{
    c.AddPolicy("*", opts =>
    {
        opts.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo() { Title = "Chatbot API" });
});

var app = builder.Build();
builder.WebHost.UseUrls("http://+:5001");

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Echo GFT"));

app.UseCors(opts =>
{
    opts.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
});

app.UseRouting()
    .UseEndpoints(e =>
    {
        e.MapGet("/ping", async context => await context.Response.WriteAsync("pong"));
        e.MapControllers();
    });

app.Run();
