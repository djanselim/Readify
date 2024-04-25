using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Readify.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
