using Microsoft.EntityFrameworkCore;

namespace asp_dotnet_core_guestbook.Models
{
    public class MyWebApiContext : DbContext
    {
        public MyWebApiContext(DbContextOptions<MyWebApiContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}