using DocumentNumber.ValidatorAbstractions;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentValidatorController : ControllerBase
    {
        private readonly ILogger<DocumentValidatorController> _logger;
        private readonly IDocumentNumberValidator _validator;

        public DocumentValidatorController(
            ILogger<DocumentValidatorController> logger,
            IDocumentNumberValidator validator)
        {
            this._logger = logger;
            this._validator = validator;
        }
        [HttpGet("{documentId}")]
        public async Task<IActionResult> DocumentValidateAsync(string documentId)
        {
            var result = _validator.Validate(documentId);
            await Task.CompletedTask;
            return Ok(result);
        }
    }
}
