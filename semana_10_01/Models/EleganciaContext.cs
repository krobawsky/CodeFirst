using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace semana_10_01.Models
{
    public class EleganciaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EleganciaContext() : base("name=EleganciaContext")
        {
        }

        public System.Data.Entity.DbSet<semana_10_01.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<semana_10_01.Models.Pedido> Pedidoes { get; set; }

        public System.Data.Entity.DbSet<semana_10_01.Detalle> Detalles { get; set; }

        public System.Data.Entity.DbSet<semana_10_01.Models.Producto> Productoes { get; set; }
    }
}
