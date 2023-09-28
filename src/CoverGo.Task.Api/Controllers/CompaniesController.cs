using CoverGo.Task.Application;
using CoverGo.Task.Domain;

using Microsoft.AspNetCore.Mvc;

namespace CoverGo.Task.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CompaniesController : ControllerBase
{
    private readonly ICompaniesQuery _companiesQuery;

    public CompaniesController(ICompaniesQuery companiesQuery)
    {
        _companiesQuery = companiesQuery;
    }

    [HttpGet(Name = "GetCompanies")]
    public async ValueTask<ActionResult<List<Company>>> GetAll()
    {
        return await _companiesQuery.ExecuteAsync();
    }
}
