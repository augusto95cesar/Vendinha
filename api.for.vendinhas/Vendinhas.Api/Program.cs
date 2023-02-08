using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Vendinha.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Vendinha Controle",
        Description = "Controle de dividas dos Clientes",
        Version = "v1"
    });
});

var connectionString = builder.Configuration.GetConnectionString("VendinhaContext");
builder.Services.AddSqlite<VendinhaContext>(connectionString);

var app = builder.Build();

await AsseguraDBExiste(app.Services);

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Vendinha Controle");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

async Task AsseguraDBExiste(IServiceProvider services)
{
    using var db = services.CreateScope().ServiceProvider.GetRequiredService<VendinhaContext>();
    await db.Database.EnsureCreatedAsync();
    await db.Database.MigrateAsync();
}