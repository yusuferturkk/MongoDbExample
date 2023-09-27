using AgrowFarmProject.Models;
using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.Controllers
{
	public class AdminWhyUsController : Controller
	{
        private readonly IWhyUsRepository _whyUsRepo;

        public AdminWhyUsController(IWhyUsRepository whyUsRepo)
        {
            _whyUsRepo = whyUsRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var value = await _whyUsRepo.GetAllAsync();
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Update(WhyUs whyUs)
        {
            await _whyUsRepo.UpdateAsync(whyUs);
            return View();
        }
    }
}
