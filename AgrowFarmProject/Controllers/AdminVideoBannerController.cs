using AgrowFarmProject.Models;
using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.Controllers
{
	public class AdminVideoBannerController : Controller
	{
        private readonly IVideoBannerRepository _videoBannerRepo;

        public AdminVideoBannerController(IVideoBannerRepository videoBannerRepo)
        {
            _videoBannerRepo = videoBannerRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var value = await _videoBannerRepo.GetAllAsync();
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Update(VideoBanner videoBanner)
        {
            await _videoBannerRepo.UpdateAsync(videoBanner);
            return View();
        }
    }
}
