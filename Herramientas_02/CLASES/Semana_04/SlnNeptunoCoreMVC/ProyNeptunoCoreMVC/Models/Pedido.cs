﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProyNeptunoCoreMVC.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            DetallesPedidos = new HashSet<DetallesPedido>();
        }

        public int IdPedido { get; set; }
        public string IdCliente { get; set; }
        public int? IdEmpleado { get; set; }
        public DateTime? FechaPedido { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public int? FormaEnvio { get; set; }
        public decimal? Cargo { get; set; }
        public string Destinatario { get; set; }
        public string DireccionDestinatario { get; set; }
        public string CiudadDestinatario { get; set; }
        public string RegionDestinatario { get; set; }
        public string CodPostalDestinatario { get; set; }
        public string PaisDestinatario { get; set; }
        public string Eliminado { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual ICollection<DetallesPedido> DetallesPedidos { get; set; }
    }
}
