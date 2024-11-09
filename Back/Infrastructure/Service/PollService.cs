using Back.Domain.Dto;
using Back.Domain.Infrastructure;
using Back.Domain.models;
using Back.Domain.Service;

namespace Back.Infrastructure.Service;

public class PollService : IPollService
{
    private readonly IPollRepository _pollRepository;

    public PollService(IPollRepository pollRepository)
    {
        _pollRepository = pollRepository;
    }
    
    public async Task<IEnumerable<Poll>> GetAllPolls()
    {
        var polls = await _pollRepository.ReadAllAsync();
        return polls;
    }

    public async Task<Poll> CreatePoll(CreatePollDto pollDto)
    {
        var polls = await _pollRepository.ReadAllAsync();
        var size = polls.Count();
        var poll = pollDto.CreatePoll(size); 
        
        await _pollRepository.CreateAsync(poll);
        return poll;
    }

    public async Task VotePoll(int pollId, int pollItemId)
    {
        await _pollRepository.VoteForAPollItem(pollId, pollItemId);
    }
}