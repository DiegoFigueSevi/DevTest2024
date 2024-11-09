using Back.Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDependencyInjection();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder
            .AllowAnyOrigin() 
            .AllowAnyMethod() 
            .AllowAnyHeader()); 
});


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Task API v1");
        options.RoutePrefix = string.Empty; 
    });
}

app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();

app.Run();

