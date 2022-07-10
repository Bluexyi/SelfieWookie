using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfieWookie.Core.Selfies.Domain;

namespace SelfieWookie.Api.UI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        #region Public methods
        //[HttpGet]
        //public IEnumerable<Selfie> TestAMoi()
        //{
        //    return Enumerable.Range(1, 10).Select(item => new Selfie() { Id = item });
        //}

        [HttpGet]
        public IActionResult TestAMoi()
        {
            var model = Enumerable.Range(1, 10).Select(item => new Selfie() { Id = item });

            //return this.StatusCode(StatusCodes.Status204NoContent);

            return this.Ok(model);
        }
        #endregion
    }
}
