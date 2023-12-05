namespace Medusa.Infrastructure.Interfaces;

using Medusa.Application.Persons.ViewModels;

internal interface IPersonReadService
{
    Task<Person?> GetPersonWithNameLength(Guid id, CancellationToken cancellationToken = default);
}
