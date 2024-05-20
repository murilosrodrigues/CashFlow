namespace CashFlow.Exception.ExceptionBase;

public class ErrorOnValidationException : CashFlowEception
{
    public List<string> ErrorMessages { get; set; }
    public ErrorOnValidationException(List<string> errorMessages)
    {
        ErrorMessages = errorMessages;
            
    }
}
