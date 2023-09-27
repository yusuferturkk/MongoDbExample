using AgrowFarmProject.Models;
using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.Controllers
{
	public class AdminStatisticController : Controller
	{
        private readonly IStatisticRepository _statisticRepo;

        public AdminStatisticController(IStatisticRepository statisticRepo)
        {
            _statisticRepo = statisticRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var value = await _statisticRepo.GetAllAsync();
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Statistic statistic)
        {
            await _statisticRepo.UpdateAsync(statistic);
            return View();
        }
    }
}
