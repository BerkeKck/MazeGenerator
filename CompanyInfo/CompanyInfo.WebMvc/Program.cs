namespace CompanyInfo.WebMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews(); //MVC için grekli servisleri yükler


            var app = builder.Build();
            app.UseStaticFiles(); //burasý wwwroot klasorunu web'e acar

            //app.MapGet("/", () => "Hello World!");
            app.MapControllerRoute(
                name:"default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.Run();
        }
    }
}
//shift f9