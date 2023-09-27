using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.ViewComponents.Default
{
	public class _StatisticPartial : ViewComponent
	{
		private readonly IStatisticRepository _statisticRepo;

        public _StatisticPartial(IStatisticRepository statisticRepo)
        {
            _statisticRepo = statisticRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var values =await _statisticRepo.GetAllAsync();
			return View(values);
		}
	}
}
