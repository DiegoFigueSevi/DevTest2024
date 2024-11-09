using Back.Domain.models;

namespace Back.Domain.Dto;

public class CreatePollDto
{
    public string Name { get; set; }
    public List<string> Options { get; set; }

    private List<PollItem> _createItems()
    {
        return Options.Select((option, index) => new PollItem {Id = index+1, Name = option, Votes = 0}).ToList();
    }

    public Poll CreatePoll(int id)
    {
        return new Poll
        {
            Id = id,
            Name = Name,
            Options = _createItems()
        };
    }
}