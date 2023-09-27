using AgrowFarmProject.Models;
using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.Controllers
{
	public class AdminTestimonialController : Controller
	{
        private readonly ITestimonialRepository _testimonialRepo;

        public AdminTestimonialController(ITestimonialRepository testimonialRepo)
        {
            _testimonialRepo = testimonialRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var value = await _testimonialRepo.GetAllAsync();
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Testimonial testimonial)
        {
            await _testimonialRepo.UpdateAsync(testimonial);
            return View();
        }
    }
}
