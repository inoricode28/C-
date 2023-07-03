using System;
using System.Collections.Generic;

#nullable disable

namespace ProyNeptunoCoreMVC.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }
        public string Eliminado { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
