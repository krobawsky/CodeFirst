using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using semana_10_01.Models;

namespace semana_10_01.Models
{
    public class Pedido
    {
        [Key]
        [Display(Name = "Numero de Orden")]
        public int IdPedido { get; set; }

        [Display(Name = "Fecha de Orden")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FechaPedido { get; set; }

        [Display(Name = "Codigo de Cliente")]
        public int IdCliente { get; set; }

        // definir el pedido para el cliente y varios detalles para el pedido
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Detalle> Detalles { get; set; }

    }
}