using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_project.Models;
using web_project.ViewModel;

namespace web_project.Controllers
{
    public class HomeController : Controller
    {
        websiteEntities db = new websiteEntities();
        /*[HttpGet]
        public ActionResult Index()
        {
            /*List<Vki> grup = new List<Vki>()
            {
                new Vki(){Id=1,Sonuc="Hesaplanan Vücut Kitle İndeksinize Göre Zayıfsınız."},
                new Vki(){Id=2,Sonuc="Hesaplanan Vücut Kitle İndeksinize Göre Normal Kilolusunuz."},
                new Vki(){Id=3,Sonuc="Hesaplanan Vücut Kitle İndeksinize Göre Fazla Kilolusunuz."},
                new Vki(){Id=4,Sonuc="Hesaplanan Vücut Kitle İndeksinize Göre Tip 1 Obezsiniz."},
                new Vki(){Id=5,Sonuc="Hesaplanan Vücut Kitle İndeksinize Göre Tip 2 Obezsiniz."},
                new Vki(){Id=6,Sonuc="Hesaplanan Vücut Kitle İndeksinize Göre Morbid Obezsiniz."},
                new Vki(){Id=7,Sonuc="Hesaplanan Vücut Kitle İndeksinize Göre Süper Obezsiniz."},
                new Vki(){Id=8,Sonuc="Hesaplanan Vücut Kitle İndeksinize Göre Süper Süper Obezsiniz."}
            };
           
            return View();
        }*/
        [HttpGet]
        public ActionResult Users()
        {
            List<users> user = db.users.ToList();
            return View(user);
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection frm)
        {
            double kg = (Convert.ToDouble(frm["kg"].ToString()))/1000;
            double boy = (Convert.ToDouble(frm["boy"].ToString())) / 100;

            double vki = kg / (boy * boy);
            if (vki < 18.5)
            {
                ViewBag.deger = vki.ToString();
                ViewBag.sonuc="Hesaplanan Vücut Kitle İndeksinize Göre Zayıfsınız.";
            }
            if (vki >= 18.5 & vki < 24.9)
            {
                ViewBag.deger = vki.ToString();
                ViewBag.sonuc = "Hesaplanan Vücut Kitle İndeksinize Göre Normal Kilolusunuz.";
            }
            if (vki >= 24.9 & vki < 30)
            {
                ViewBag.deger = vki.ToString();
                ViewBag.sonuc = "Hesaplanan Vücut Kitle İndeksinize Göre Fazla Kilolusunuz.";
            }
            if (vki >= 30 & vki < 35)
            {
                ViewBag.deger = vki.ToString();
                ViewBag.sonuc = "Hesaplanan Vücut Kitle İndeksinize Göre Tip 1 Obezsiniz.";
            }
            if (vki >= 35 & vki < 40)
            {
                ViewBag.deger = vki.ToString();
                ViewBag.sonuc = "Hesaplanan Vücut Kitle İndeksinize Göre Tip 2 Obezsiniz.";
            }
            if (vki >= 40 & vki < 50)
            {
                ViewBag.deger = vki.ToString();
                ViewBag.sonuc = "Hesaplanan Vücut Kitle İndeksinize Göre Morbid Obezsiniz.";
            }
            if (vki >= 50 & vki < 60)
            {
                ViewBag.deger = vki.ToString();
                ViewBag.sonuc = "Hesaplanan Vücut Kitle İndeksinize Göre Süper Obezsiniz.";
            }
            if (vki >= 60)
            {
                ViewBag.deger = vki.ToString();
                ViewBag.sonuc = "Hesaplanan Vücut Kitle İndeksinize Göre Süper Süper Obezsiniz.";
                ViewBag.warn = "alert alert-success";
            }
            return View();
        }
        
        public ActionResult addUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addUser(userModel model)
        {
            users user = new users();

            user.usernameSurname = model.usernameSurname;
            user.email = model.email;
            user.kg = model.kg;
            user.boy = model.boy;
            user.birth = model.birth;
            user.area = model.area;
            user.address = model.address;
            user.tel = model.tel;
            user.passwd = model.passwd;
            user.water = model.water;

            db.users.Add(user);
            db.SaveChanges();

            ViewBag.sonuc = "Üye Kaydı Yapıldı!";
            return View();
        }

        public ActionResult updateUser(int ? id)
        {
            users user = db.users.Where(k => k.id == id).SingleOrDefault();

            userModel model = new userModel();
            model.id = user.id;
            model.usernameSurname = user.usernameSurname;
            model.email = user.email;
            model.kg = user.kg;
            model.boy = user.boy;
            model.birth = user.birth;
            model.area = user.area;
            model.address = user.address;
            model.tel = user.tel;
            model.passwd = user.passwd;
            model.water = user.water;

            return View(model);
        }
        [HttpPost]
        public ActionResult updateUser(userModel m)
        {
            users user = db.users.Where(k => k.id == m.id).SingleOrDefault();

            user.usernameSurname = m.usernameSurname;
            user.email = m.email;
            user.kg = m.kg;
            user.boy = m.boy;
            user.birth = m.birth;
            user.area = m.area;
            user.address = m.address;
            user.tel = m.tel;
            user.passwd = m.passwd;
            user.water = m.water;

            db.SaveChanges();
            ViewBag.sonuc = "Kayıt Güncellendi!";
            return View();
        }
        public ActionResult deleteUser(int ? id)
        {
            users user=db.users.Where(k=>k.id==id).SingleOrDefault();
            db.users.Remove(user);
            db.SaveChanges();

            return RedirectToAction("Users");
        }


        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Exercise()
        {
            return View();
        }
        public ActionResult Comment()
        {
            return View();
        }
    }
}