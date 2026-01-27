// Create dependency injection container
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddOpenApi();  // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

// Build the application
var app = builder.Build();

// Configure the HTTP request pipeline
// Order of operations matter
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Use attribute-based routing
app.MapControllers(); // newer shortcut for adding useRouting and useEndpoints

app.Run();
