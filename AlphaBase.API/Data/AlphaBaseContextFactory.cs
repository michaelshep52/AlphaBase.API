using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Alpha.API.Data
{
    public class AlphaBaseContextFactory //: IDesignTimeDbContextFactory<AlphaBaseContext>
    {
        /*public AlphaBaseContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            return new AlphaBaseContext(new DbContextOptionsBuilder<AlphaBaseContext>().Options, config);
        }*/
    }
}

