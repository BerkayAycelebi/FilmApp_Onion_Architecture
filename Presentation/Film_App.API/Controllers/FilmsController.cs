using Film_App.Application.Absractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Film_App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {

        private readonly IFilmService _filmService;

        public FilmsController(IFilmService filmService)
        {
          _filmService = filmService;
        }
        [HttpGet]
        public IActionResult GetFilms()
        {
            var films = _filmService.GetFilms();
            return Ok(films);
        }
    }
}
