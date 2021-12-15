using AwesomeShop.BusinessLogic.Shared;
using MentalHealth.BL.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ValidationException = System.ComponentModel.DataAnnotations.ValidationException;

namespace MentalHealth.API.Shared
{
    public class ApplicationExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.Result = context.Exception switch
            {
                ResourceNotFoundException => new NotFoundResult(),
                ValidationException => new BadRequestResult(),
                BusinessLogicException => new BadRequestResult(),
                _ => context.Result
            };
        }
    }
}
