using System.Reflection.Emit;
using Alpha.API.Data.Entities;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;


namespace Alpha.API.Data
{
    public class AlphaBaseContext : DbContext
    {
        
        private readonly IConfiguration _config;

        public AlphaBaseContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }
      
        public DbSet<User>? User { get; set; }
        public DbSet<EmailAddress>? EmailAddresses { get; set; }
        public DbSet<Address>? Address { get; set; }
        public DbSet<Phone>? Phone { get; set; }
        public DbSet<Payment>? Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=AlphaBase;Username=michaelshepherd;Password=Laelynes5267!")
                .EnableSensitiveDataLogging();
            //Add to help with migrations for Datetime timestamp!!!!
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        }

        protected override void OnModelCreating(ModelBuilder bldr)
        {
            bldr.Entity<User>()
              .HasData(new
              {
                  UserId = 1,
                  FirstName = "Michael",
                  LastName = "Shepherd",
                  Password = "Password1234321!",
                  AddressId = 1,
                  EmailAddressId = 1,
                  PhoneId = 1,
                  PaymentId = 1
              });

            bldr.Entity<Address>()
              .HasData(new
              {
                  AddressId = 1,
                  Address1 = "1461 Upper Second Creek Road",
                  Address2 = "",
                  Address3 = "",
                  CityTown = "Hazard",
                  StateProvince = "KY",
                  PostalCode = "41701",
                  Country = "USA",
                  UserId = 1
              });

            bldr.Entity<EmailAddress>()
             .HasData(new
             {
                 EmailAddressId = 1,
                 Email = "michaelshep52@gmail.com",
                 UserId = 1
             });

            bldr.Entity<Phone>()
             .HasData(new
             {
                 PhoneId = 1,
                 PhoneNumber = 606-438-4485,
                 UserId = 1
             });

            bldr.Entity<Payment>()
             .HasData(new
             {
                 PaymentId = 1,
                 UserId = 1
             });
        }
    }
}
    

