using Exam_ExampleForTest_17_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam_ExampleForTest_17_01.Controllers
{
    public class CEOController : Controller
    {
        public static List<CEO> listo = new List<CEO>()
        {
            new CEO (1,"Osh",24,"OT@Gmail",25000),
            new CEO (2,"riel",25,"Zagay@Gmail",27000),
            new CEO (3,"Osh",27,"OOOTTT@Gmail",29000),
            new CEO (4,"Osh",30,"OT@Gmail",35000),

        };
        // GET: CEO
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowCEOName()
        {
            ViewBag.CEOName = listo[0].Name;
            return View();
        }
        public ActionResult ShowCEOInfo(int id)
        {
           CEO ceo= listo.Find(x=>x.Id==id);    
            return View(ceo);
        }
     
    }
}