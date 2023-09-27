using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.ViewComponents.Default
{
	public class _AboutPartial : ViewComponent
	{
		private readonly IAboutRepository _aboutRepo;

        public _AboutPartial(IAboutRepository aboutRepo)
        {
            _aboutRepo = aboutRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _aboutRepo.GetAllAsync();
			return View(values);
		}
	}
}
