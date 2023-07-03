using Microsoft.AspNetCore.Mvc;

using ec_01_Vicuñawebapp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ec_01_Vicuñawebapp.Controllers
{
    public class VicuñaEC01Controller : Controller
    {   
        BDTRANSITO22Context con = new BDTRANSITO22Context();


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PapeletasFechas(DateTime? dato, DateTime? dato2) 
        {
            var lista = con.Papeletas
                            .Include(x =>x.NroplaNavigation)
                            .Include(x => x.CodpolNavigation)
                            .Include(x => x.CodinfNavigation)
                            .Where(c => c.Fechapap >= dato && c.Fechapap <=dato2).ToList();

            ViewBag.cantidad_registros = lista.Count;
            ViewBag.ultima_papeleta = lista.Select(c => c.Nropap).LastOrDefault();


            return View(lista);
        }

        public IActionResult PapeletasPoliciaAnio(String id, int dato) 
        {
            var lista = con.Papeletas
                            .Include(x=>x.NroplaNavigation)
                            .Include(x=>x.CodinfNavigation)
                            .Include(x=>x.CodpolNavigation)
                            .Where(c => c.Codpol.Equals(id) && c.Fechapap.Value.Year == dato).ToList();

            ViewBag.lista_policias = new SelectList(
                    con.Policias.ToList(),
                    "Codpol",
                    "Codpol"
             );


            ViewBag.cantidad = lista.Count();
            ViewBag.suma = lista.Sum(c => c.CodinfNavigation.Importe);

            return View(lista);
        }
    }
}
