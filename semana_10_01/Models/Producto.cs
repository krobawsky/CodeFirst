using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace semana_10_01.Models
{
    public class Producto
    {
        [Key]
        [Display(Name = "Codigo del Producto")]
        public int IdProducto { get; set; }

        [Display(Name = "Nombre del Producto")]
        public string NombreProducto { get; set; }

        [Display(Name = "Precio Unidad")]
        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode = false)]
        public decimal PrecioProducto { get; set; }

        public virtual ICollection<Detalle> Detalles { get; set; }

    }
}