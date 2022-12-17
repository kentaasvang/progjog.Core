namespace progjog.Web.Data.Entities;

public class TrainingSegment
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public TimeSpan Duration { get; set; }
    public decimal Pace { get; set; }
}