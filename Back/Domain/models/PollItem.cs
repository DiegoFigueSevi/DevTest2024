namespace Back.Domain.models;

public class PollItem : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? Votes { get; set; }
}