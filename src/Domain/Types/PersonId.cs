namespace Medusa.Domain.Types;

public record struct PersonId
{
    public Guid Value { get; private init; }

    public PersonId(Guid value) => this.Value = value;
}
