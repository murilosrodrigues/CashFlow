﻿namespace CashFlow.Communication.Responses;

public class ResponseErrorJson
{
    public List<string> ErrorMessages { get; set; } 

    public ResponseErrorJson(string errorMessage)
    {
        ErrorMessages = [errorMessage];// new List<string> { errorMessage };
    }
    
    public ResponseErrorJson(List<string> errorMessage)
    {
        ErrorMessages = errorMessage;
    }
}