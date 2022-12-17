
using Mapster;
using MapsterMapper;

namespace progjog.Web;

public static class AddMapsterExtensions
{
    public static void AddMapster(this IServiceCollection services)
    {
        var config = GetConfiguration();

        services.AddSingleton(config);
        services.AddTransient<IMapper, ServiceMapper>();
    }

    private static TypeAdapterConfig GetConfiguration()
    {
        var config = new TypeAdapterConfig
        {
            RequireExplicitMapping = true,
            RequireDestinationMemberSource = true
        };
        config.Compile();
        return config;
    }
}