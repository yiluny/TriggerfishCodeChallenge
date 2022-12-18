using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TriggerfishCodingChallenge.Repositories;

namespace TriggerfishCodingChallenge.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataRepository _dataRepository;

        public HomeController() : this(new LocalDataRepository())
        {
        }

        public HomeController(IDataRepository dataRepository)
        {
            this._dataRepository = dataRepository;
        }

        public ActionResult Index()
        {
            var output = this._dataRepository.GetArticleCollection();
            return View(output);
        }
    }
}