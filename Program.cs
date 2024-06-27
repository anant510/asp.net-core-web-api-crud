using Microsoft.EntityFrameworkCore;
using thirdProject.context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<secondContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("secondPractice")));

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI(
   options =>
   {
       options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
       options.RoutePrefix = string.Empty;
       options.DocumentTitle = "My Swagger";

   }
);

app.Run();
