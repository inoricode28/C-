using Microsoft.AspNetCore.Mvc;

using ProyNeptunoCoreMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.AspNetCore.Mvc.Rendering; // SelectList


namespace ProyNeptunoCoreMVC.Controllers
{
    public class ConsultasController : Controller
    {
        // definir la variable del contexto entity framework core
        Neptuno2022Context db = new Neptuno2022Context();

        // GET
        public IActionResult PedidosPorCliente(string idcliente= "")
        {
            // obtener los datos del modelo
            var listado = db.Pedidos
                            .Where(c => c.IdCliente.Equals(idcliente))
                            .ToList();

            //
            ViewBag.Cant_Pedidos = listado.Count;
            ViewBag.Suma_Cargos = listado.Sum( p => p.Cargo );

            ViewData["Cantidad2"] = listado.Count;
            TempData["Suma_Cargos2"] = listado.Sum(p => p.Cargo);

            // enviando los datos de los clientes en un viewbag para 
            // usarlo en un dropdownlist
            ViewBag.lista_clientes = new SelectList(
                   db.Clientes.ToList(), // data                
                   "IdCliente",    // nombre del campo principal
                   "NombreCliente" // nombre del campo a mostrar datos
                );

            // enviar el modelo a la vista
            return View(listado);
        }

        // 13-06-2023

        // CONSULTA DE PEDIDOS POR FECHA
        public IActionResult PedidosPorFecha(DateTime? fecha)
        {
            if (fecha == null)
                fecha = new DateTime(2022, 06, 01); // 30-10-2021

            var listado = db.Pedidos
                            .Include( x => x.IdClienteNavigation)  // Clientes
                            .Include( x => x.IdEmpleadoNavigation) // Empleados
                            .Where(p => p.FechaPedido >= fecha)
                            //.Where( p => p.FechaPedido.Value.Day == 2022)
                            .ToList();

            ViewBag.contador = listado.Count;
            ViewBag.suma = listado.Sum(x => x.Cargo);

            return View(listado);  
        }





    }
}
