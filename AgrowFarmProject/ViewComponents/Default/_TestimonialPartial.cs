using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.ViewComponents.Default
{
	public class _TestimonialPartial : ViewComponent
	{
		private readonly ITestimonialRepository _testimonialRepo;

        public _TestimonialPartial(ITestimonialRepository testimonialRepo)
        {
            _testimonialRepo = testimonialRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var values =await _testimonialRepo.GetAllAsync();
			return View(values);
		}
	}
}
