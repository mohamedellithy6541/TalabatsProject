using Microsoft.EntityFrameworkCore;
using Talabats.DataLayer.Implimentions;
using Talabats.DataLayer.Repositories;
using Talabats.RepositoryLayer.Data;

namespace Talabats
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationContext>(
             option => option.UseSqlServer(builder.Configuration.GetConnectionString("conf")));
          
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            var app = builder.Build();
            using var scope = app.Services.CreateScope();
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var context = services.GetRequiredService<ApplicationContext>();
                    await context.Database.MigrateAsync(); //To update Database 
                }
                catch (Exception ex)
                { 

                    /// to SHOW ERROR OR LOGGING AT CONSOLE App 
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError(ex,ex.Message);
                }
            }
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}