using AgrowFarmProject.Models;
using AgrowFarmProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AgrowFarmProject.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IBannerRepository _bannerService;
		private readonly IAboutRepository _aboutService;
		private readonly IOurServiceRepository _ourServiceService;
		private readonly IStatisticRepository _statisticService;
		private readonly ITestimonialRepository _testimonialService;
		private readonly IVideoBannerRepository _videoBannerService;
		private readonly IWhyUsRepository _whyUsService;

        public HomeController(ILogger<HomeController> logger, IBannerRepository bannerService, IAboutRepository aboutService, IOurServiceRepository ourServiceService, IStatisticRepository statisticService, ITestimonialRepository testimonialService, IVideoBannerRepository videoBannerService, IWhyUsRepository whyUsService)
        {
            _logger = logger;
            _bannerService = bannerService;
            _aboutService = aboutService;
            _ourServiceService = ourServiceService;
            _statisticService = statisticService;
            _testimonialService = testimonialService;
            _videoBannerService = videoBannerService;
            _whyUsService = whyUsService;
        }

		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult BannerPartial()
		{
			var values = _bannerService.GetAllAsync();
			return PartialView(values);
		}
		public PartialViewResult AboutPartial()
		{
			var values = _aboutService.GetAllAsync();
			return PartialView(values);
		}
		public PartialViewResult OurServicePartial()
		{
			var values = _ourServiceService.GetAllAsync();
			return PartialView(values);
		}
		public PartialViewResult StatisticPartial()
		{
			var values = _statisticService.GetAllAsync();
			return PartialView(values);
		}
		public PartialViewResult TestimonialPartial()
		{
			var values = _testimonialService.GetAllAsync();
			return PartialView(values);
		}
		public PartialViewResult VideoBannerPartial()
		{
			var values = _videoBannerService.GetAllAsync();
			return PartialView(values);
		}
		

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}