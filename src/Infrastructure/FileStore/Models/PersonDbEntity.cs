namespace Medusa.Infrastructure.FileStore.Models;

internal sealed record class PersonDbEntity
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
}
