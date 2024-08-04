using Microsoft.EntityFrameworkCore;
using System.Xml;
using TunifyPlatform.Models;


namespace TunifyPlatform.Data
{
    public class TunifyDbContext : DbContext
    {

        public TunifyDbContext(DbContextOptions<TunifyDbContext> options)
        : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<PlaylistSongs> PlaylistSongs { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<Subscription> Subscription { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlaylistSongs>()
                .HasKey(pk => new { pk.PlaylistSongsId });

            // Seed Artists 
            modelBuilder.Entity<Artist>().HasData(
                  new Artist { ArtistId = 1, Name = "Artist Name", Bio = "Artist Bio" }
            );
            


            // Seed Users
            modelBuilder.Entity<Users>().HasData(
                new Users { UsersId = 1, Username = "Ibrahim Nimer", Email = "ibrahim@gmail.com", Join_Date = new DateTime(2024, 8, 4), Subscription_ID = 1 }
            );


            // Seed Songs
            modelBuilder.Entity<Song>().HasData(
                new Song { SongId = 1, Title = "Some One Like You", ArtistId = 1 }
            );


            // Seed Playlists
            modelBuilder.Entity<Playlist>().HasData(
                new Playlist { PlaylistId = 1, UsersId = 1, Playlist_Name = "Fav", Created_Date = new DateTime(2024, 8, 4) }
            );
        }


    }
}
