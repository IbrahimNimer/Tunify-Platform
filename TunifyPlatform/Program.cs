using Microsoft.EntityFrameworkCore;
using TunifyPlatform.Data;
using TunifyPlatform.Repositories.Services;
using TunifyPlatform.Repositories.Interfaces;


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


            builder.Services.AddScoped<IUser, UserService>();
            builder.Services.AddScoped<IArtist, ArtistService>();
            builder.Services.AddScoped<IPlaylist, PlaylistService>();
            builder.Services.AddScoped<ISongs, SongService>();


            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapControllers();
            app.Run();


        }
    }
}
