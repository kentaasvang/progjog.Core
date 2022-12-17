using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.Extensions.Configuration;

namespace progjog.Web.Data;

public class DesignTimeApplicationDbContextFactory
{
    /// <summary>
    /// This class is only used by `dotnet ef`-CLI tool when running migrations
    /// </summary>
    public class DesignTimeApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var connectionString = GetConnectionString(args);
            var version = ServerVersion.AutoDetect(connectionString);

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseMySql(connectionString, version);

            return new ApplicationDbContext(optionsBuilder.Options);
        }

        private string GetConnectionString(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets("aspnet-progjog.Web-30CA2D82-8137-4C3C-B371-8518A645FC06")
                .Build();

            var connectionString = config["Database:ConnectionString"] ??
                                   throw new NullReferenceException(
                                       $"'connectionString' is missing in {nameof(DesignTimeApplicationContextFactory)}");

            return connectionString;
        }
    }
}