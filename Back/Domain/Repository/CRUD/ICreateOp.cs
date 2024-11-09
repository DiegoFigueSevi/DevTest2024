using Back.Domain.models;

namespace Back.Domain.Infrastructure.CRUD;

public interface ICreateOp<T> where T : IEntity
{
    Task<T> CreateAsync(T entity);
}