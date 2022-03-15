using Microsoft.EntityFrameworkCore;
using UserEntity;

namespace UserDataAccess
{
    public class UserDBContext:DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options):base(options)
        {
            
        }
        public UserDBContext() 
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string connectionString  = @"server = localhost; user = root; password = welat.123; database = rise1;";
        //    optionsBuilder.UseMySql(connectionString:connectionString , ServerVersion.AutoDetect(connectionString)); //Cannot find this method
        //}
        public DbSet<Kisi>  Kisi { get; set; }
        public DbSet<Iletisim>  Iletisim { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kisi>().HasKey(p => p.Id);
            modelBuilder.Entity<Iletisim>().HasKey(p => p.Id);
            modelBuilder.Entity<Kisi>().HasOne<Iletisim>().WithMany().HasForeignKey(p => p.ILetisimRefId);

        }

    }
}
