
using api_dados_prestadores.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace api_dados_prestadores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<PrestadorContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PrestadorContext")));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();
            builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            else
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<PrestadorContext>();
                context.Database.EnsureCreated();
                DbInitializer.Initialize(context);
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors();
            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });

            app.MapControllers();

            app.Run();
        }
    }
}