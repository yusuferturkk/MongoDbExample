using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.ViewComponents.Default
{
	public class _VideoBannerPartial : ViewComponent
	{
		private readonly IVideoBannerRepository _videoBannerRepo;

        public _VideoBannerPartial(IVideoBannerRepository videoBannerRepo)
        {
            _videoBannerRepo = videoBannerRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var values =await _videoBannerRepo.GetAllAsync();
			return View(values);
		}
	}
}
