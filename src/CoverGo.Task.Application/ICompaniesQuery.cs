using CoverGo.Task.Domain;

namespace CoverGo.Task.Application;

public interface ICompaniesQuery
{
    public ValueTask<List<Company>> ExecuteAsync();
}
