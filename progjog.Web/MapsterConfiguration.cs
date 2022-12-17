using Mapster;
using progjog.Web.Data.Entities;
using progjog.Web.Models;

namespace progjog.Web;

public static class MapsterConfiguration
{
    public static TypeAdapterConfig GetConfiguration()
    {
        var config = new TypeAdapterConfig
        {
            RequireExplicitMapping = true,
            RequireDestinationMemberSource = true
        };

        config.AddMappings();
        
        config.Compile();
        
        return config;
    }

    private static void AddMappings(this TypeAdapterConfig config)
    {
        config.NewConfig<TrainingPlan, TrainingPlanViewModel>()
            .Map(dest => dest.Owner, source => source.Owner.UserName)
            .Map(dest => dest.Weeks, source => source.Duration);
    }
}