using DeveloperAssesment.Models;
using DeveloperAssesment.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Books API",
        Version = "v1",
        Description = "API for managing books with sorting and citation formats."
    });
});

builder.Services.AddDbContextPool<Context>(opt =>
opt.UseSqlServer(builder.Configuration.GetConnectionString("scon")));
builder.Services.AddScoped<IBookRepo, BookRepo>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Books API V1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
