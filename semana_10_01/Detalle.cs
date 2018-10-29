using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using semana_10_01.Models;

namespace semana_10_01
{
    public class Detalle
    {
        [Key]
        [Display(Name = "Numero de Detalle")]
        public int IdDetalle { get; set; }

        [Display(Name = "Codigo de Orden")]
        public int IdPedido { get; set; }

        [Display(Name = "Codigo de Producto")]
        public int IdProducto { get; set; }

        [Display(Name = "Precio Unidad")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal PrecioUnidad { get; set; }

        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        public virtual Pedido Pedido { get; set; }
        public virtual Producto Producto { get; set; }

    }
}