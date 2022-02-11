using _13439_MatviiZakrevskyi_zd3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13439_MatviiZakrevskyi_zd3.Controllers
{
    public class ListaController : Controller
    {
        public List<ZakupClass> ListaZakupow = new List<ZakupClass>();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Lista(ZakupClass zakup)
        {
            if (string.IsNullOrEmpty(zakup.Nazwa))
                ModelState.AddModelError(nameof(zakup.Nazwa), "IsNullOrEmpty");

            if (zakup.Liczba < 0)
                ModelState.AddModelError(nameof(zakup.Liczba), "< 0");

            if (zakup.Cena < 0)
                ModelState.AddModelError(nameof(zakup.Cena), "< 0");

            if (ModelState.IsValid)
            {
                ListaZakupow.Add(zakup);
                return View(ListaZakupow);
            }
            else
            {
                return View("Index", zakup);
            }
            
        }
    }
}
