using Back.AuxDataBase;
using Back.Domain.Infrastructure;
using Back.Domain.models;

namespace Back.Infrastructure.Repository;

public class PollLocalRepository : IPollRepository
{

    private List<Poll> _polls = AuxDb.Polls;
    
    public async Task<Poll> CreateAsync(Poll entity)
    {
        _polls.Add(entity);
        return entity;
    }

    public async Task<IEnumerable<Poll>> ReadAllAsync()
    {
        return _polls;
    }

    public async Task VoteForAPollItem(int pollId, int pollItemId)
    {
        _polls.ForEach(
            poll => poll.Options.ForEach(
                item =>
                {
                    if (item.Id == pollItemId) item.Votes++;
                }
            )
        );
    }
}