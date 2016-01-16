using System;
using System.Linq;
using System.Web.Mvc;
using Fill_Drop_Down_list.Models;

namespace Fill_Drop_Down_list.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Province = new SelectList(Database.GetProvince(), "Id", "Name");
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult City(int id)
        {
            return Json(Database.FindCity().Where(x => x.Province_Id == id), JsonRequestBehavior.AllowGet);
        }
    }
}