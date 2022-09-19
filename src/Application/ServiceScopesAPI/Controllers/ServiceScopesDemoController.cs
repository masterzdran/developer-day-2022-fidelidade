using Microsoft.AspNetCore.Mvc;

namespace ServiceScopesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceScopesDemoController : ControllerBase
    {
        private readonly ILogger<ServiceScopesDemoController> _logger;
        private readonly ServiceScopeDemo.IServiceScope _serviceScope;
        private readonly ServiceScopeDemo.IServiceScope _serviceScope2;

        public ServiceScopesDemoController(
            ILogger<ServiceScopesDemoController> logger,
            ServiceScopeDemo.IServiceScope serviceScope,
            ServiceScopeDemo.IServiceScope serviceScope2)
        {
            _logger = logger;
            _serviceScope = serviceScope;
            _serviceScope2 = serviceScope2;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAsync()
        {
            var result = $"{_serviceScope.GetId()} :: {_serviceScope2.GetId()}";
            await Task.CompletedTask;
            return Ok(result);
        }
    }
}
