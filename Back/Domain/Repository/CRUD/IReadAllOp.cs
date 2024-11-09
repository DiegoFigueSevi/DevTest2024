using Back.Domain.models;

namespace Back.Domain.Infrastructure.CRUD;

public interface IReadAllOp<T> where T : IEntity
{
    Task<IEnumerable<T>> ReadAllAsync();
}