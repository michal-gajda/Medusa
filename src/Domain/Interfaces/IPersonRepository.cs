namespace Medusa.Domain.Interfaces;

using Medusa.Domain.Entities;

public interface IPersonRepository
{
    Task CreateAsync(PersonEntity entity, CancellationToken cancellationToken = default);
}
