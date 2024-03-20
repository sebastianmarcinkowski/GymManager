using GymManager.UI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.UI.Controllers;

public abstract class BaseController : Controller
{
    private ISender _mediatr;
    protected ISender MediatR
        => _mediatr ??= HttpContext.RequestServices.GetService<ISender>();

    protected async Task<MediatorValidateResponse<T>>
        MediatorSendValidate<T>(IRequest<T> request)
    {
        var response = new MediatorValidateResponse<T> { IsValid = false };

        try
        {
            if (ModelState.IsValid)
            {
                response.Model = await MediatR.Send(request);
                response.IsValid = true;
                return response;
            }
        }
        catch (Application.Common.Exceptions.ValidationException exception)
        {
            foreach (var item in exception.Errors)
                ModelState.AddModelError(item.Key, string.Join(". ", item.Value));
        }

        return response;
    }
}
