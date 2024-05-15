using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Request;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensasController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        try
        {
            var respone = new RegisterExpenseUseCase().Execute(request);

            return Created(string.Empty, respone);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Unknown error.");
        }
    }
}
