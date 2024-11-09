namespace Back.Domain.models;

public class Poll : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<PollItem> Options { get; set; }
}