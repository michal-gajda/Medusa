namespace Medusa.Infrastructure.FileStore.Services;

using System;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Medusa.Application.Persons.ViewModels;
using Medusa.Infrastructure.Interfaces;
using Medusa.Infrastructure.FileStore.Models;
using System.Text.RegularExpressions;

internal sealed class PersonReadService : IPersonReadService
{
    public async Task<Person?> GetPersonWithNameLength(Guid id, CancellationToken cancellationToken = default)
    {
        var fileName = $"{id}.json";

        if (File.Exists(fileName) is false)
        {
            return await Task.FromResult(default(Person));
        }

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
        };

        var json = File.ReadAllText(fileName, Encoding.UTF8);

        var person = JsonSerializer.Deserialize<PersonDbEntity>(json, options);

        if (person is null)
        {
            return await Task.FromResult(default(Person));
        }

        var result = new Person
        {
            Id = person.Id,
            Name = person.Name,
            NameLength = person.Name.Length,
        };

        return await Task.FromResult(result);
    }
}
