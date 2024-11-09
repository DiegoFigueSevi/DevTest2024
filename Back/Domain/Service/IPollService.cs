using Back.Domain.Dto;
using Back.Domain.models;

namespace Back.Domain.Service;

public interface IPollService
{
    Task<IEnumerable<Poll>> GetAllPolls();
    Task<Poll> CreatePoll(CreatePollDto poll);
    Task VotePoll(int pollId, int pollItemId);
}