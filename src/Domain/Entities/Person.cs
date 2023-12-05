namespace Medusa.Domain.Entities;

using Medusa.Domain.Types;

public sealed class PersonEntity
{
    public PersonId Id { get; private init; }
    public string Name { get; private set; } = string.Empty;

    public PersonEntity(PersonId id, string name)
    {
        this.Id = id;
        this.SetName(name);
    }

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(nameof(name));
        }

        this.Name = name;
    }
}
