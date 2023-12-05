namespace Medusa.Application.Persons.ViewModels;

public sealed record class Person
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required int NameLength { get; init; }
}
