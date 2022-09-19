using Microsoft.AspNetCore.Mvc;
using Portugal.Nif.Validator;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NifValidatorController : ControllerBase
    {
        [HttpGet("{nifDocumentId}")]
        public async Task<IActionResult> NifValidateAsync(string nifDocumentId)
        {
            NifValidator nifValidator = new NifValidator();
            var result = nifValidator.Validate(nifDocumentId);
            await Task.CompletedTask;
            return Ok(result);
        }
    }
}
