using Microsoft.AspNetCore.Mvc;

namespace ManageGateway.Tests.Extensions
{
    public static class ActionResultExtension
    {
        public static T GetObjectResult<T>(this ActionResult<T> result) =>
            result.Result != null
                ? (T)((ObjectResult)result.Result).Value
                : result.Value;
    }
}
