using Bogus;
using CashFlow.Communication.Enums;
using CashFlow.Communication.Request;
using System.ComponentModel.DataAnnotations;

namespace CommonTestUtilities.Request;

public class RequestRegisterExpenseJsonBuilder
{

    public static RequestRegisterExpenseJson Build()
    {
       return  new Faker<RequestRegisterExpenseJson>()
             .RuleFor(r => r.Title, Faker => Faker.Commerce.ProductName())
             .RuleFor(r => r.Description, Faker => Faker.Commerce.ProductDescription())
             .RuleFor(r => r.Date, Faker => Faker.Date.Past())
             .RuleFor(r => r.PaymenteType, Faker => Faker.PickRandom<PaymentType>())
             .RuleFor(r => r.Amount, Faker => Faker.Random.Decimal(min: 1, max: 1000));
    }

}
