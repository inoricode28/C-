using Microsoft.AspNetCore.Mvc;
using EC01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Drawing;
using System.ComponentModel.DataAnnotations;


namespace EC01.Controllers
{
    public class ChavezEC01Controller : Controller        
    {
        BDTRANSITO22Context bd = new BDTRANSITO22Context();
        public IActionResult PapeletasFechas(DateTime? data1, DateTime? data2)
        {
            var lista = bd.Papeletas
                            .Include(x => x.NroplaNavigation)
                            .Include(x => x.CodpolNavigation)
                            .Include(x => x.CodinfNavigation)
                            .Where(c => c.Fechapap >= data1 && c.Fechapap <= data2).ToList();

            ViewBag.cant_regis = lista.Count;
            ViewBag.ultima_papelt = lista.Select(c => c.Nropap).LastOrDefault();


            return View(lista);

        }

        public IActionResult PapeletasPoliciaAnio(String id, int data)
        {
            var lista = bd.Papeletas
                            .Include(x => x.NroplaNavigation)
                            .Include(x => x.CodinfNavigation)
                            .Include(x => x.CodpolNavigation)
                            .Where(c => c.Codpol.Equals(id) && c.Fechapap.Value.Year == data).ToList();

            ViewBag.lista_policias = new SelectList(
                    bd.Policias.ToList(),
                    "Codpol",
                    "Codpol"
             );


            ViewBag.cant01 = lista.Count();
            ViewBag.add01 = lista.Sum(c => c.CodinfNavigation.Importe);

            return View(lista);
        }

    }
    
}
