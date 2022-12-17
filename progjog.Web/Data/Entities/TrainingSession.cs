namespace progjog.Web.Data.Entities;

public class TrainingSession
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public DateTime Date { get; set; }
    public List<TrainingSegment> TrainingSegments { get; set; } = new();
}