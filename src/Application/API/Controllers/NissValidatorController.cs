using DocumentNumber.Portugal.Niss.Validator;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NissValidatorController : ControllerBase
  {
    [HttpGet("{nissDocumentId}")]
    public async Task<IActionResult> NissValidateAsync(string nissDocumentId)
    {
      NissValidator nissValidator = new NissValidator();
      var result = nissValidator.Validate(nissDocumentId);
      await Task.CompletedTask;
      return Ok(result);
    }
  }
}
