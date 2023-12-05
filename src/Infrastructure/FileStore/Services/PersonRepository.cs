namespace Medusa.Infrastructure.FileStore.Services;

using System.Text;
using System.Text.Json;
using Medusa.Domain.Entities;
using Medusa.Domain.Interfaces;
using Medusa.Infrastructure.FileStore.Models;

internal sealed class PersonRepository : IPersonRepository
{
    public async Task CreateAsync(PersonEntity entity, CancellationToken cancellationToken = default)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
        };

        var person = new PersonDbEntity
        {
            Id = entity.Id.Value,
            Name = entity.Name,
        };

        var json = JsonSerializer.Serialize(person, options);

        File.WriteAllText($"{entity.Id.Value}.json", json, Encoding.UTF8);

        await Task.CompletedTask;
    }
}
