using CoverGo.Task.Domain;

namespace CoverGo.Task.Application;

public interface ICompaniesWriteRepository
{
    public ValueTask<Company> GetById(string id, CancellationToken cancellationToken = default);
}
