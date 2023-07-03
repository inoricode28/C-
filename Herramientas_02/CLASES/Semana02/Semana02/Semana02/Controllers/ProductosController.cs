using Microsoft.AspNetCore.Mvc;
using Semana02.Models;
using System.Collections.Generic;

namespace Semana02.Controllers
{
    public class ProductosController : Controller
    {
        static Productos prod2 = new Productos()
        {
            cod_prod = 1002,
            nom_prod = "Cocina",
            pre_prod = 1099,
            skt_prod = 30,
            fecha_cad = new System.DateTime(2028, 5, 30)
        };
        private static List<Productos> listaProd = new List<Productos>()
        {
            new Productos()
            {
                cod_prod=1001,nom_prod="Televisor",pre_prod=1985,
                skt_prod=20, fecha_cad=new System.DateTime(2030,10,20)
            },
            prod2
        };

        public IActionResult IndexProductos()
        {
            // obtener los datos del modelo
            List<Productos> listado = listaProd;



            // enviar los datos del modelo a la vista
            return View(listado);



            //return View(listaProd);
        }
    }
}
