using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Multi_UnitOfWork.Services;

namespace Multi_UnitOfWork.Controllers
{
	public class FilmController : ControllerBase
	{
		private readonly IFilmService _filmService;

		public FilmController(IFilmService filmService)
		{
			_filmService = filmService;
		}

		public async Task<ActionResult> Get()
		{
			var result = await _filmService.GetFilms();
			return Ok(result);
		}
	}
}