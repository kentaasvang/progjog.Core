using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using progjog.Web.Data.Entities;

namespace progjog.Web.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<TrainingPlan> TrainingPlans => Set<TrainingPlan>();
    public DbSet<TrainingSession> TrainingSessions => Set<TrainingSession>();
    public DbSet<TrainingSegment> TrainingSegments => Set<TrainingSegment>();
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}