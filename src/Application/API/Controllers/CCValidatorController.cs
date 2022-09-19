using DocumentNumber.Portugal.CitizenCard.Validator;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CCValidatorController : ControllerBase
  {
    [HttpGet("{ccDocumentId}")]
    public async Task<IActionResult> CCValidateAsync(string ccDocumentId)
    {
      CitizenCardValidator ccValidator = new CitizenCardValidator();
      var result = ccValidator.Validate(ccDocumentId);
      await Task.CompletedTask;
      return Ok(result);
    }
  }
}
