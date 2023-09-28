using System.Collections.Immutable;

using CoverGo.Task.Application;
using CoverGo.Task.Domain;

namespace CoverGo.Task.Infrastructure.Persistence.InMemory;

internal class InMemoryCompaniesRepository : ICompaniesQuery, ICompaniesWriteRepository
{
    private readonly ImmutableList<Company> _seedwork = new List<Company>
    {
        new() { Id = "0", Name = "ABC" },
        new() { Id = "1", Name = "CoverGo" },
        new() { Id = "2", Name = "Horns & Hooves" },
    }.ToImmutableList();

    public ValueTask<Company> GetById(string id, CancellationToken cancellationToken = default)
    {
        return ValueTask.FromResult(_seedwork.Single(it => it.Id == id));
    }

    public ValueTask<List<Company>> ExecuteAsync()
    {
        return ValueTask.FromResult(_seedwork.ToList());
    }
}
