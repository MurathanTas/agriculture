using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _NewsAnnoucPartial:ViewComponent
	{
		private readonly INewsAnnoucService _newsAnnoucService;

		public _NewsAnnoucPartial(INewsAnnoucService newsAnnoucService)
		{
			_newsAnnoucService = newsAnnoucService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _newsAnnoucService.GetListAll();
			return View(values);
		}
	}
}
