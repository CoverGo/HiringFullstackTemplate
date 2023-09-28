using CoverGo.Task.Application;
using CoverGo.Task.Domain;

using Microsoft.AspNetCore.Mvc;

namespace CoverGo.Task.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PlansController : ControllerBase
{
    private readonly IPlansQuery _plansQuery;

    public PlansController(IPlansQuery plansQuery)
    {
        _plansQuery = plansQuery;
    }

    [HttpGet(Name = "GetPlans")]
    public async ValueTask<ActionResult<List<Plan>>> GetAll()
    {
        return await _plansQuery.ExecuteAsync();
    }
}
