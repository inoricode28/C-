using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ProyTransitoCore_SP.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc.Rendering; // SelectList

namespace ProyTransitoCore_SP.Controllers
{
    public class VehiculoController : Controller
    {
        private readonly BDTRANSITO22Context db;

        public VehiculoController(BDTRANSITO22Context _db)
        {
            db = _db;
        }

        // GET: VehiculoController
        public ActionResult ListarVehiculos()
        {
            return View(db.Vehiculos.ToList());
        }

        // GET: VehiculoController/Details/5
        public ActionResult DetalleVehiculo(string id)
        {
            Vehiculo buscado = db.Vehiculos.Find(id);

            return View(buscado);
        }

        // GET: VehiculoController/Create
        public ActionResult GrabarVehiculo()
        {
            // definir una nueva variable del modelo
            Vehiculo obj = new Vehiculo();
            // obj.FechaProd = new DateTime(2030, 6, 27);

            // enviando la lista de propietarios a la vista 
            ViewBag.Propietarios = new SelectList(
                db.Propietarios.ToList(),
                "Dnipro", "Nompro"
                );

            // enviar el nuevo modelo a la vista
            return View(obj);
        }

        // POST: VehiculoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GrabarVehiculo(Vehiculo nuevo)
        {
            try
            {
                // si todo es correcto (el modelo a grabarse no contiene
                // errores)
                if (ModelState.IsValid == true)
                {
                    db.Vehiculos.Add(nuevo);
                    TempData["Mensaje"] = "Vehiculo registrado correctamente";
                }
                //
                return RedirectToAction(nameof(ListarVehiculos));
            }
            catch(Exception ex)
            {
                TempData["Mensaje"] = ex.Message;
            }
            // enviando la lista de propietarios a la vista 
            ViewBag.Propietarios = new SelectList(
                db.Propietarios.ToList(),
                "Dnipro", "Nompro"
                );
            //
            return View(nuevo);
        }

        // GET: VehiculoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehiculoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(ListarVehiculos));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehiculoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehiculoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(ListarVehiculos));
            }
            catch
            {
                return View();
            }
        }
    }
}
