
using Microsoft.EntityFrameworkCore;
using Northwind.BL.Abstract;
using Northwind.BL.Concrete;
using Northwind.Entites.Entities;
using Northwind.Entites.Sakila;

namespace NorthWind.Api
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<NorthwindContext>(p => p.UseSqlServer(builder.Configuration.GetConnectionString("Northwind")));

            builder.Services.AddDbContext<SakilaContext>(p => p.UseMySQL(builder.Configuration.GetConnectionString("sakila")));

            builder.Services.AddScoped<IMySqlCategory,MySqlCategory>();
            builder.Services.AddScoped<IActorManager,ActorManager>();

            builder.Services.AddScoped(typeof(IManager<,>), typeof(Manager<,>));
            //builder.Services.AddScoped<IMsSqlCategory, MsSqlCategory>();

            // IManager Interface'i 2 adet generic parametre beklediginden 
            //Bunu ifade etmek icin <,> ifadesi kullanilir
            builder.Services.AddScoped(typeof(IManager<,>),typeof(Manager<,>));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
