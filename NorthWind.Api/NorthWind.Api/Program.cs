
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
                   ValidateAudience = true,// token üzerinde Audience doðrulamasýný aktifleþtirdik.
                   ValidAudience = "https://localhost:7071",//uygulamadaki tokenýn Audience deðerini belirledik.
                   ValidateIssuer = true,//token üzerinde Issuer doðrulamasýný aktifleþtirdik.
                   ValidateLifetime = true,// token deðerinin kullaným süresi doðrulamasýný aktifleþtirdik.
                   ValidateIssuerSigningKey = true,//token deðerinin bu uygulamaya ait olup olmadýðýný anlamamýzý saðlayan Security Key doðrulamasýný aktifleþtirdik.
                   ValidIssuer = "https://localhost:7071",//uygulamadaki tokenýn Issuer deðerini belirledik.
                 
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Benim Super Sifrem Benim Super Sifrem Benim Super Sifrem 123qweasd!!")),// Security Key doðrulamasý için SymmetricSecurityKey nesnesi aracýlýðýyla mevcut keyi belirtiyoruz.
                   ClockSkew = TimeSpan.Zero //TimeSpan.Zero deðeri ile token süresinin üzerine ekstra bir zaman eklemeksizin sýfýr deðerini belirtiyoruz.

               });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication(); // Once Kimlik Dogrulamasi 
            app.UseAuthorization();  // Sonra Yetkilendirme


            app.MapControllers();

            app.Run();
        }
    }
}
