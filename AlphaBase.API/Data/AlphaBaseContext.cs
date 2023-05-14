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

        public AlphaBaseContext()
        {
        }

        public AlphaBaseContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }
      
        public DbSet<User> User { get; set; }
        public DbSet<EmailAddress> EmailAddresses { get; set; }
        //public DbSet<Address>? Address { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Payment> Payments { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_config.GetConnectionString("AlphaBase"));
            //Add to help with migrations for Datetime timestamp!!!!
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql(
              "Host=localhost;Database=AlphaBase;Username=michaelshepherd;Password=Laelynes5267!",
          options => options.MaxBatchSize(100))
          .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name },
                          //DbLoggerCategory.Database.Transaction.Name},
                          LogLevel.Debug)
              .EnableSensitiveDataLogging();
        /*  

           protected override void OnModelCreating(ModelBuilder bldr)
           {
               /*bldr.Entity<User>()
                   .HasOne(e => e.Address)
                   .WithOne(e => e.User)
                   .HasForeignKey<Address>(e => e.UserId)
                   .IsRequired();

               bldr.Entity<EmailAddress>()
                   .HasOne(e => e.User)
                   .WithMany(e => e.EmailAddress)
                   .HasForeignKey(e => e.UserId)
                   .IsRequired();

               bldr.Entity<Phone>()
                   .HasOne(e => e.User)
                   .WithMany(e => e.Phones)
                   .HasForeignKey(e => e.UserId)
                   .IsRequired();

               bldr.Entity<User>()
                  .HasMany(e => e.Payments)
                  .WithOne(e => e.User)
                  .HasForeignKey(e => e.UserId)
                  .IsRequired();

               bldr.Entity<User>()
                 .HasData(new
                 {
                     UserId = 1,
                     FirstName = "Michael",
                     LastName = "Shepherd",
                     Password = "Password1234321!",
                 });

               bldr.Entity<Address>()
                 .HasData(new
                 {
                     AddressId = 1,
                     Address1 = "1461 Upper Second Creek Road",
                     CityTown = "Hazard",
                     StateProvince = "KY",
                     PostalCode = "41701",
                     Country = "USA",
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
                    PhoneNumber = "606-438-4485",
                    UserId = 1
                });

               bldr.Entity<Payment>()
                .HasData(new
                {
                    PaymentId = 1,
                    UserId = 1
                });
           }*/
    }
}
    

