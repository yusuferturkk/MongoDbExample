using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.ViewComponents.Default
{
	public class _BannerPartial : ViewComponent
	{
		private readonly IBannerRepository _bannerRepo;

        public _BannerPartial(IBannerRepository bannerRepo)
        {
            _bannerRepo = bannerRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _bannerRepo.GetAllAsync();
			return View(values);
		}
	}
}
