using DocumentNumber.Portugal.Niss.Validator;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NissValidatorController : ControllerBase
  {
    private readonly ILogger<NifValidatorController> _logger;
    private readonly INissValidator _validator;

    public NissValidatorController(
      ILogger<NifValidatorController> logger,
      INissValidator validator)
    {
      this._logger = logger;
      this._validator = validator;
    }
    [HttpGet("{nissDocumentId}")]
    public async Task<IActionResult> NissValidateAsync(string nissDocumentId)
    {
      var result = _validator.Validate(nissDocumentId);
      await Task.CompletedTask;
      return Ok(result);
    }
  }
}
