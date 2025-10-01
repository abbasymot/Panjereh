using Microsoft.EntityFrameworkCore;
using Panjereh.Models;

namespace Panjereh.Services
{
    public class DbService : DbContext
    {
        public DbSet<Book> Books { get; set; }

        private string DbPath;

        public DbService()
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            DbPath = System.IO.Path.Combine(folder, "panjerre.db");
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
