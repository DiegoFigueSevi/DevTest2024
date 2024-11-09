using Back.Domain.Infrastructure.CRUD;
using Back.Domain.models;

namespace Back.Domain.Infrastructure;

public interface IPollRepository : ICreateOp<Poll>, IReadAllOp<Poll>
{
    Task VoteForAPollItem(int pollId, int pollItemId);
}

