using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjektiZadatak.UI.Interfaces;
using ProjektniZadatak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektiZadatak.Controllers
{
    public class RadnikController : Controller
    {
        private readonly IRadnikUI _iradnikUI;

        public RadnikController(IRadnikUI radnikUI)
        {
            _iradnikUI = radnikUI;
        }
        // GET: RadnikController
        public ActionResult Index()
        {
            var radnici = _iradnikUI.DajSveRadnike();
            return View(radnici);
        }

        public ActionResult Dodaj()
        {
            return View();
        }

        public RedirectToActionResult DodavanjeRadnika(Radnik r)
        {
            var radnik = _iradnikUI.DodajRadnika(r);
            
            return RedirectToAction("Detalji", "Radnik", r);
        }

        public RedirectToActionResult Izbrisi(int ID)
        {
            _iradnikUI.Izbrisi(ID);

            return RedirectToAction("Index", "Radnik");
        }

        public ActionResult Detalji(int ID)
        {
            var radnik = _iradnikUI.DajRadnika(ID);
            return View(radnik);
        }


    }
}
