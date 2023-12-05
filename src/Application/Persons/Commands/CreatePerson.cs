namespace Medusa.Application.Persons.Commands;

using MediatR;

public sealed record class CreatePerson : IRequest
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
}
