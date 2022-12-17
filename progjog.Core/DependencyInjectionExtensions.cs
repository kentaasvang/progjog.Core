using Microsoft.EntityFrameworkCore;
using progjog.Core.Data;

namespace progjog.Core;

public static class DependencyInjectionExtensions
{
    public static void AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config["Database:ConnectionString"] ?? 
                               throw new NullReferenceException($"'connectionString' is missing in {nameof(AddApplicationDbContext)}");
        
        var serverVersion = ServerVersion.AutoDetect(connectionString);

        services.AddDbContext<ApplicationDbContext>(
            options =>
            {
                options.UseMySql(connectionString, serverVersion);
            });
        
        services.AddDatabaseDeveloperPageExceptionFilter();
    }
}