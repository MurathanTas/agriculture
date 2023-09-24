using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class NewsAnnoucController : Controller
    {
        private readonly INewsAnnoucService _newsAnnoucService;

        public NewsAnnoucController(INewsAnnoucService newsAnnoucService)
        {
            _newsAnnoucService = newsAnnoucService;
        }

        public IActionResult Index()
        {
            var values = _newsAnnoucService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddNewsAnnouc()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewsAnnouc(NewsAnnouc newsannouc)
        {
            newsannouc.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            newsannouc.Status = false;
            _newsAnnoucService.Insert(newsannouc);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteNewsAnnouc(int id)
        {
            var values = _newsAnnoucService.GetById(id);
            _newsAnnoucService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet] 
        public IActionResult EditNewsAnnouc(int id)
        {
            var values = _newsAnnoucService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditNewsAnnouc(NewsAnnouc newsannouc)
        {
            _newsAnnoucService.Update(newsannouc);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusTrue(int id)
        {
            _newsAnnoucService.NewsAnnoucStatusToTrue(id);
            return RedirectToAction("Index");   
        }

        public IActionResult ChangeStatusFalse(int id)
        {
            _newsAnnoucService.NewsAnnoucStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}
