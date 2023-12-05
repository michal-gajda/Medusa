namespace Medusa.Application.Persons.Queries;

using MediatR;
using Medusa.Application.Persons.ViewModels;

public sealed record class GetPersons : IRequest<IEnumerable<Person>>
{
}
