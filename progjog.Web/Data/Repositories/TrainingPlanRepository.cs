using Mapster;
using MapsterMapper;
using progjog.Web.Models;

namespace progjog.Web.Data.Repositories;

public interface ITrainingPlanRepository
{
    public List<TrainingPlanViewModel> GetAll();
}

public class TrainingPlanRepository : ITrainingPlanRepository
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public TrainingPlanRepository(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public List<TrainingPlanViewModel> GetAll()
    {
        var queryable = from trainingPlan in _dbContext.TrainingPlans
                        select trainingPlan;

        return _mapper.Map<List<TrainingPlanViewModel>>(queryable);
    }
}