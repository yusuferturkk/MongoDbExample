using AgrowFarmProject.Models;
using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.Controllers
{
	public class AdminOurServiceController : Controller
	{
        private readonly IOurServiceRepository _ourServiceRepo;

        public AdminOurServiceController(IOurServiceRepository ourServiceRepo)
        {
            _ourServiceRepo = ourServiceRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var value = await _ourServiceRepo.GetAllAsync();
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Update(OurService ourService)
        {
            await _ourServiceRepo.UpdateAsync(ourService);
            return View();
        }
    }
}
