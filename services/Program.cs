using entity;
using Microsoft.EntityFrameworkCore;
using services;

var builder = WebApplication.CreateBuilder(args);

// Agregar acceso de FrontEnd
var CorsConfiguration = "corspolicy";
builder.Services.AddCors(options => {
    options.AddPolicy(
        name: CorsConfiguration,
        builder =>
        {
            builder.WithOrigins(
                "http://localhost:4200"
                , "http://localhost:4201"
                )
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BackContext>(options=>options.UseSqlServer(builder.Configuration["ConnectionStrings:cnDB"]));
builder.Services.ConfigureRepositoryManager();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{ 
    BackContext context = scope.ServiceProvider.GetRequiredService<BackContext>();
    context.Database.Migrate();
}

app.UseHttpsRedirection();

app.UseCors(CorsConfiguration);

app.UseAuthorization();

app.MapControllers();

app.Run();
