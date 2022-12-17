using Microsoft.Extensions.DependencyInjection;

namespace progjog.Web.Data.Repositories;

public static class AddRepositoriesExtensions
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<ITrainingPlanRepository, TrainingPlanRepository>();
    }
}