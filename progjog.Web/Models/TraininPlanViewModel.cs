namespace progjog.Web.Models;

public class TrainingPlanViewModel
{
    public string Id    { get; set; } = null!;
    public string Owner { get; set; } = null!;
    public int    Weeks { get; set; }
}