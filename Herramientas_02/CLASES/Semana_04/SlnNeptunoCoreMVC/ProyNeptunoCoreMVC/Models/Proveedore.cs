﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProyNeptunoCoreMVC.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string NombreContacto { get; set; }
        public string CargoContacto { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string CodPostal { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string PaginaPrincipal { get; set; }
        public string Eliminado { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
