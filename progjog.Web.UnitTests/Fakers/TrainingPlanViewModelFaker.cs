using Bogus;
using progjog.Web.Models;

namespace progjog.Web.UnitTests.Fakers;

public static class TrainingPlanViewModelFaker
{
    public static Faker<TrainingPlanViewModel> Create()
        => new Faker<TrainingPlanViewModel>()
            .RuleFor(dest => dest.Id, faker => faker.Random.Guid().ToString())
            .RuleFor(dest => dest.Owner, faker => faker.Person.FullName)
            .RuleFor(dest => dest.Weeks, faker => faker.Random.Int(1, 26));
}