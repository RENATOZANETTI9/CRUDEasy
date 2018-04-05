using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyTalents.Models;

namespace EasyTalents.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult getBesttimes()
        {
            using (talentsEntities ctx = new talentsEntities())
            {
                return Json(ctx.besttimes.ToList(), JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult getAvailabilities()
        {
            using (talentsEntities ctx = new talentsEntities())
            {
                return new JsonResult { Data = ctx.availabilities.ToList(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        [HttpGet]
        public JsonResult getTalents()
        {
            using (talentsEntities ctx = new talentsEntities())
            {
                var talents = ctx.talents.ToList();
                return Json(talents, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        public JsonResult addTalent(talent newTalent)
        {
            using (talentsEntities ctx = new talentsEntities())
            {
                ctx.talents.Add(newTalent);
                ctx.SaveChanges();
                var talents = ctx.talents.ToList();
                return Json(talents, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult deleteTalent(talent delTalent)
        {
            using (talentsEntities ctx = new talentsEntities())
            {
                var tal = ctx.talents.Find(delTalent.Id);
                ctx.talents.Remove(tal);
                ctx.SaveChanges();
                var talents = ctx.talents.ToList();
                return Json(talents, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult updateTalent(talent uptTalent)
        {
            using (talentsEntities ctx = new talentsEntities())
            {
                talent tal = ctx.talents.Find(uptTalent.Id);

                tal.email = uptTalent.email;
                tal.name_ = uptTalent.name_;
                tal.skype = uptTalent.skype;
                tal.phone = uptTalent.phone;
                tal.linkedin = uptTalent.linkedin;
                tal.city = uptTalent.city;
                tal.state = uptTalent.state;
                tal.portifolio = uptTalent.portifolio;
                tal.id_availability = uptTalent.id_availability;
                tal.id_besttime = uptTalent.id_besttime;
                tal.hourlySalary = uptTalent.hourlySalary;
                tal.bankYourName = uptTalent.bankYourName;
                tal.bankName = uptTalent.bankName;
                tal.bankCPF = uptTalent.bankCPF;
                tal.bankAgency = uptTalent.bankAgency;
                tal.bankAccountType = uptTalent.bankAccountType;
                tal.bankAccountNumber = uptTalent.bankAccountNumber;
                tal.ionic = uptTalent.ionic;
                tal.android = uptTalent.android;
                tal.ios = uptTalent.ios;
                tal.html = uptTalent.html;
                tal.css = uptTalent.css;
                tal.bootstrap = uptTalent.bootstrap;
                tal.jquery = uptTalent.jquery;
                tal.angularJs = uptTalent.angularJs;
                tal.java = uptTalent.java;
                tal.aspnetMVC = uptTalent.aspnetMVC;
                tal.languageC = uptTalent.languageC;
                tal.languageCPlusPlus = uptTalent.languageCPlusPlus;
                tal.cake = uptTalent.cake;
                tal.django = uptTalent.django;
                tal.majento = uptTalent.majento;
                tal.PHP = uptTalent.PHP;
                tal.vue = uptTalent.vue;
                tal.wordperss = uptTalent.wordperss;
                tal.python = uptTalent.python;
                tal.ruby = uptTalent.ruby;
                tal.sqlServer = uptTalent.sqlServer;
                tal.mysql = uptTalent.mysql;
                tal.salesforce = uptTalent.salesforce;
                tal.photophop = uptTalent.photophop;
                tal.illustrator = uptTalent.illustrator;
                tal.seo = uptTalent.seo;
                tal.others = uptTalent.others;
                tal.crudLink = uptTalent.crudLink;


                if (TryUpdateModel(tal, "", new string[] { }))
                {
                    ctx.SaveChanges();
                }
                var talents = ctx.talents.ToList();
                return Json(talents, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult editTalent(talent editTalent)
        {
            using (talentsEntities ctx = new talentsEntities())
            {
                var tal = ctx.talents.Find(editTalent.Id);
                tal = editTalent;
                var talents = ctx.talents.ToList();
                return Json(talents, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}