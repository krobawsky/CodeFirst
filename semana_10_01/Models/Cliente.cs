using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace semana_10_01.Models
{
    public class Cliente
    {
        [Key]
        [Display(Name = "Codigo del Cliente")]
        public int IdCliente { get; set; }

        [Display(Name = "Nombre de la Compañia")]
        [Required(ErrorMessage = "El campo {0} es oblicagorio")]
        public string NombreCompañia { get; set; }

        [Display(Name = "Nomber del Contacto")]
        public string NombreContacto { get; set; }

        // un cliente puede realizar uno o varios pedidos
        public virtual ICollection<Pedido> Pedidos { get; set; }

    }
}