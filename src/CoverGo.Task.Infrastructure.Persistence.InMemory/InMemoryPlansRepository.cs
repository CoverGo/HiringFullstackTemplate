using System.Collections.Immutable;

using CoverGo.Task.Application;
using CoverGo.Task.Domain;

namespace CoverGo.Task.Infrastructure.Persistence.InMemory;

internal class InMemoryPlansRepository : IPlansQuery, IPlansWriteRepository
{
    private readonly ImmutableList<Plan> _seedwork = new List<Plan>
    {
        new() { Id = "0", Name = "Base" },
        new() { Id = "1", Name = "Premium" },
    }.ToImmutableList();

    public ValueTask<Plan> GetById(string id, CancellationToken cancellationToken = default)
    {
        return ValueTask.FromResult(_seedwork.Single(it => it.Id == id));
    }

    public ValueTask<List<Plan>> ExecuteAsync()
    {
        return ValueTask.FromResult(_seedwork.ToList());
    }
}
