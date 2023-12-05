namespace Medusa.Application.Persons.Queries;

using MediatR;
using Medusa.Application.Persons.ViewModels;

public sealed record class GetPerson : IRequest<Person?>
{
    public required Guid Id { get; init; }
}
