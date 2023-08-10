using FiltersWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FiltersWebApi.Controllers
{
    [Route("api/workPlace")]
    [ApiController]
    public class WorkPlaceController : ControllerBase
    {
        private readonly IWorkPlaceService _workPlaceService;

        public WorkPlaceController(IWorkPlaceService workPlaceService)
        {
            _workPlaceService = workPlaceService;
        }

        [HttpGet("workInfo")]
        public async Task<IActionResult> GetWorkPlaces()
        {
            var res=await _workPlaceService.GetWorkPlaces();
            return Ok(res);
        }
    }
}
