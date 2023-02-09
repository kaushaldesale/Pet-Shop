using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Micraft_Solutions.Data_Context;
namespace Micraft_Solutions.Controllers
{
    public class ActionTakenController : Controller
    {
        // GET: ActionTaken
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Partial_View(int id)
        {
            t_order model;
            model = new t_order()
            {
                Order_id=id
            };
          
            return View(model);  
        }
        public ActionResult Action_Taken(t_order model)
        {
            var Action = model.attr3;
            using(Db_MicraftEntities _context = new Db_MicraftEntities())
            {
                _context.t_order.Attach(model);
                _context.Entry(model).Property(x => x.attr3).IsModified = true;
                _context.SaveChanges();
            }

            return RedirectToAction("Main_View", "Order_Report");
        }
    }
}