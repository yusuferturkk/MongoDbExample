using AgrowFarmProject.Models;
using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.Controllers
{
	public class AdminBannerController : Controller
	{
		private readonly IBannerRepository _bannerRepo;

        public AdminBannerController(IBannerRepository bannerRepo)
        {
            _bannerRepo = bannerRepo;
        }

        [HttpGet]
		public async Task<IActionResult> Update()
		{
			var value = await _bannerRepo.GetAllAsync();
			return View(value);
		}
		
		[HttpPost]
		public async Task<IActionResult> Update(Banner banner)
		{
			await _bannerRepo.UpdateAsync(banner);
			return View();
		}
	}
}
