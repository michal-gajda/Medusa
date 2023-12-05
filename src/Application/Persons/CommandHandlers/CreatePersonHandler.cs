namespace Medusa.Application.Persons.CommandHandlers;

using MediatR;
using Medusa.Application.Persons.Commands;
using Medusa.Domain.Entities;
using Medusa.Domain.Interfaces;
using Medusa.Domain.Types;
using Microsoft.Extensions.Logging;

internal sealed class CreatePersonHandler : IRequestHandler<CreatePerson>
{
    private readonly ILogger<CreatePersonHandler> logger;
    private readonly IPersonRepository repository;

    public CreatePersonHandler(ILogger<CreatePersonHandler> logger, IPersonRepository repository)
        => (this.logger, this.repository) = (logger, repository);

    public async Task Handle(CreatePerson request, CancellationToken cancellationToken)
    {
        var personId = new PersonId(request.Id);
        var person = new PersonEntity(personId, request.Name);

        this.logger.LogInformation("Adding {PersonId} to repository", personId.Value);

        await this.repository.CreateAsync(person, cancellationToken);

        this.logger.LogInformation("Added {PersonId} to repository", personId.Value);
    }
}
