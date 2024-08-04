using Microsoft.EntityFrameworkCore;
using TunifyPlatform.Data;


namespace TunifyPlatform
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();

            string connection = builder.Configuration.GetConnectionString("DefaultConnection");


            builder.Services.AddDbContext<TunifyDbContext>(options => options.UseSqlServer(connection));

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapControllers();
            app.Run();


        }
    }
}
