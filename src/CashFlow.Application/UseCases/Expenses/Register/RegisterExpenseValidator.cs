using CashFlow.Communication.Request;
using FluentValidation;
using System.Reflection.Metadata;

namespace CashFlow.Application.UseCases.Expenses.Register;

public  class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpenseJson>
{
    public RegisterExpenseValidator()
    {
        RuleFor(expense => expense.Title).NotEmpty().WithMessage("The title is required.");
        RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage("The Amount must be greater than zero.");
        RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Expenses cannot be for the future.");
        RuleFor(expense => expense.PaymenteType).IsInEnum().WithMessage("Payment type is not valid.");
    }
}
