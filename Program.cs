var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();  // Add support for controllers

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

// Enable controllers to handle routing
app.MapControllers();  // This maps the routes to the controller actions

app.Run();
