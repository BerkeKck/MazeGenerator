
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Northwind.BL.Abstract;
using Northwind.BL.Concrete;
using Northwind.Entites.Entities;
using Northwind.Entites.Sakila;
using System.Text;

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
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options => options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
               {
                   ValidateAudience = true,// token üzerinde Audience do?rulamas?n? aktifle?tirdik.
                   ValidateIssuer = true,//token üzerinde Issuer do?rulamas?n? aktifle?tirdik.
                   ValidateLifetime = true,// token de?erinin kullan?m süresi do?rulamas?n? aktifle?tirdik.
                   ValidateIssuerSigningKey = true,//token de?erinin bu uygulamaya ait olup olmad???n? anlamam?z? sa?layan Security Key do?rulamas?n? aktifle?tirdik.
                   ValidIssuer = "https://localhost:7022",//uygulamadaki token?n Issuer de?erini belirledik.
                   ValidAudience = "https://localhost:7022",//uygulamadaki token?n Audience de?erini belirledik.
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Benim Super Sifrem Benim Super Sifrem Benim Super Sifrem")),// Security Key do?rulamas? için SymmetricSecurityKey nesnesi arac?l???yla mevcut keyi belirtiyoruz.
                   ClockSkew = TimeSpan.Zero //TimeSpan.Zero de?eri ile token süresinin üzerine ekstra bir zaman eklemeksizin s?f?r de?erini belirtiyoruz.

               });


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
