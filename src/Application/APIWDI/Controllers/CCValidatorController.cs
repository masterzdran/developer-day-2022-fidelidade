using DocumentNumber.Portugal.CitizenCard.Validator;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CCValidatorController : ControllerBase
  {
    private readonly ILogger<CCValidatorController> _logger;
    private readonly ICitizenCardValidator _validator;

    public CCValidatorController(
        ILogger<CCValidatorController> logger,
        ICitizenCardValidator validator
      )
    {
      this._logger = logger;
      this._validator = validator;

    }

    [HttpGet("{ccDocumentId}")]
    public async Task<IActionResult> CCValidateAsync(string ccDocumentId)
    {
      var result = _validator.Validate(ccDocumentId);
      await Task.CompletedTask;
      return Ok(result);
    }
  }
}
