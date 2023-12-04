using GestionChambre.Data;
using GestionChambre.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionChambre.Controllers
{
    public class ChambreController : Controller
    {
     
        private static List<Chambre> chambres = ChambreRepo.GetChambres();
        private static int Id = 6;
       
        public IActionResult Index()
        {
            ViewBag.chambres=chambres;
            return View();
        }


        [HttpGet]
        public IActionResult Ajouter() {
            Chambre chambre = new Chambre();
            chambre.Numero=Id++;
           
            return View(chambre);
        }


        [HttpPost]
        
        public IActionResult Ajouter(Chambre chambre)
        {
            chambres.Add(chambre);
            
            

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Modifier(int id)
        {
            Chambre chambre = chambres.Find(ck => ck.Numero == id);

            return View(chambre);
        }
        [HttpPost]
        public IActionResult Modifier(Chambre chambre)
        {
            Chambre c = chambres.Find(cb => cb.Numero == chambre.Numero);
            c.Type = chambre.Type;
            c.Numero_etage = chambre.Numero_etage;
            c.Date_Debut = chambre.Date_Debut;
            c.Date_Fin = chambre.Date_Fin;
           
            return RedirectToAction("Index");
        }

        public IActionResult Supprimer(int id)
        {
            Chambre chambre = chambres.Find(cb => cb.Numero == id);
            chambres.Remove(chambre);
            return RedirectToAction("Index");
        }

        public IActionResult ChambresDeuxiemeEtage()
        {
            ViewBag.chde = chambres.FindAll(ch => ch.Numero_etage == 2);
            return View();
        }

    }
}
