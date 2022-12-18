using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using progjog.Web.Data;

namespace progjog.Web;

public static class DependencyInjectionExtensions
{
    public static void AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config["Database:ConnectionString"] ??
                               throw new NullReferenceException(
                                   $"'connectionString' is missing in {nameof(AddApplicationDbContext)}");

        var version = new Version(8, 0, 31);
        var serverVersion = ServerVersion.Create(version, ServerType.MySql);

        services.AddDbContext<ApplicationDbContext>(
            options => { options.UseMySql(connectionString, serverVersion); });

        services.AddDatabaseDeveloperPageExceptionFilter();
    }

    public static void AddMapster(this IServiceCollection services)
    {
        var config = MapsterConfiguration.GetConfiguration();
        services.AddSingleton(config);
        services.AddTransient<IMapper, ServiceMapper>();
    }
}