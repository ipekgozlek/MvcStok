using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity; //modeli kütüphaneye ekledik ki veri tabanına erişebilelim

namespace MvcStok.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        MvcDbStokEntities db = new MvcDbStokEntities(); //veri tabanına erişmek için db nesnesi oluşturduk
        public ActionResult Index()
        {
            var degerler = db.TBLURUNLER.ToList(); //veri tabanındaki TBLURUNLER tablosundaki verileri listeledik
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> degerler = (from i in db.TBLKATEGORILER.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KATEGORIAD,
                                                 Value = i.KATEGORIID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler; //ViewBag ile degerler listesini view'a gönderdik
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(TBLURUNLER p3)
        {
            var ktg=db.TBLKATEGORILER.Where(m=>m.KATEGORIID == p3.TBLKATEGORILER.KATEGORIID).FirstOrDefault(); //veri tabanındaki TBLKATEGORILER tablosundaki KATEGORIID ile p3.TBLKATEGORILER.KATEGORIID eşleşen veriyi bulduk
            p3.TBLKATEGORILER = ktg;
            db.TBLURUNLER.Add(p3);
            db.SaveChanges();
            return RedirectToAction("Index"); //veri tabanına ekleme işlemi yaptıktan sonra Index sayfasına yönlendirdik
        }
        public ActionResult Sil(int id)
        {
            var urun = db.TBLURUNLER.Find(id);
            db.TBLURUNLER.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = db.TBLURUNLER.Find(id);
            List<SelectListItem> degerler = (from i in db.TBLKATEGORILER.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KATEGORIAD,
                                                 Value = i.KATEGORIID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View("UrunGetir", urun);
            
        }
        public ActionResult Guncelle(TBLURUNLER p)
        {
             var urun = db.TBLURUNLER.Find(p.URUNID); 
            urun.URUNAD = p.URUNAD;
            urun.MARKA = p.MARKA;
            urun.STOK = p.STOK;
            urun.FIYAT = p.FIYAT;
            //urun.URUNKATEGORI = p.URUNKATEGORI;
            var ktg = db.TBLKATEGORILER.Where(m => m.KATEGORIID == p.TBLKATEGORILER.KATEGORIID).FirstOrDefault(); //veri tabanındaki TBLKATEGORILER tablosundaki KATEGORIID ile p.TBLKATEGORILER.KATEGORIID eşleşen veriyi bulduk
            urun.URUNKATEGORI = ktg.KATEGORIID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}