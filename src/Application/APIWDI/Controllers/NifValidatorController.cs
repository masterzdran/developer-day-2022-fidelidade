using Microsoft.AspNetCore.Mvc;
using Portugal.Nif.Validator;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NifValidatorController : ControllerBase
    {
        private readonly ILogger<NifValidatorController> _logger;
        private readonly INifValidator _validator;

        public NifValidatorController(
          ILogger<NifValidatorController> logger,
          INifValidator validator
          )
        {
            this._logger = logger;
            this._validator = validator;
        }
        [HttpGet("{nifDocumentId}")]
        public async Task<IActionResult> NifValidateAsync(string nifDocumentId)
        {
            var result = _validator.Validate(nifDocumentId);
            await Task.CompletedTask;
            return Ok(result);
        }
    }
}
