using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace progjog.Web.Data.Entities;

public class TrainingPlan
{
    public string                Id               { get; set; } = Guid.NewGuid().ToString();
    public IdentityUser          Owner            { get; set; } = null!;
    public int                   Duration         { get; set; }
    public List<TrainingSession> TrainingSessions { get; set; } = new();
}