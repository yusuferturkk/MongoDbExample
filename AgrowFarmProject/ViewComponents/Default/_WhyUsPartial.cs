using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.ViewComponents.Default
{
	public class _WhyUsPartial:ViewComponent
	{
		private readonly IWhyUsRepository _whyUsRepo;

        public _WhyUsPartial(IWhyUsRepository whyUsRepo)
        {
            _whyUsRepo = whyUsRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var values =await _whyUsRepo.GetAllAsync();
			return View(values);
		}
	}
}
