using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.ViewComponents.Default
{
	public class _OurServicePartial : ViewComponent
	{
		private readonly IOurServiceRepository _ourServiceRepo;

        public _OurServicePartial(IOurServiceRepository ourServiceRepo)
        {
            _ourServiceRepo = ourServiceRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _ourServiceRepo.GetAllAsync();
			return View(values);
		}
	}
}
