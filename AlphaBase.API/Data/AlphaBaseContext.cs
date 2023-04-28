using Alpha.API.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace Alpha.API.Data
{
    public class AlphaBaseContext : DbContext
    {
        /*
        private readonly IConfiguration _config;

        public AlphaBaseContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }
      */
        public DbSet<User>? User { get; set; }
        public DbSet<EmailAddress>? EmailAddresses { get; set; }
        public DbSet<Address>? Address { get; set; }
        public DbSet<Phone>? Phone { get; set; }
        public DbSet<Payment>? Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseNpgsql("Host=localhost;Database=AlphaBase;Username=michaelshepherd;Password=Laelynes5267!");
            //Add to help with migrations for Datetime timestamp!!!!
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        }
    }
}

