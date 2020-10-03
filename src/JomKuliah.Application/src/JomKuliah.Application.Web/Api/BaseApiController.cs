using Microsoft.AspNetCore.Mvc;

namespace JomKuliah.Application.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
