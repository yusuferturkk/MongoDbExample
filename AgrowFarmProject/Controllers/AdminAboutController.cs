using AgrowFarmProject.Models;
using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.Controllers
{
	public class AdminAboutController : Controller
	{
		private readonly IAboutRepository _aboutRepo;

        public AdminAboutController(IAboutRepository aboutRepo)
        {
            _aboutRepo = aboutRepo;
        }

		[HttpGet]
		public async Task<IActionResult> Update()
		{
            var value = await _aboutRepo.GetAllAsync();
            return View(value);
		}
		
		[HttpPost]
		public async Task<IActionResult> Update(About about)
		{
			await _aboutRepo.UpdateAsync(about);
			return View();
		}
	}
}
