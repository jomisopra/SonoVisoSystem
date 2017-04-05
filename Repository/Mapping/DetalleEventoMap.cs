using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Entidades;

namespace Repository.Mapping
{
    public class DetalleEventoMap : EntityTypeConfiguration<DetalleEvento>
    {
        public DetalleEventoMap()
        {
            this.HasKey(p => new {p.IdProductoFk, p.IdEventoFk });


            this.Property(p => p.Fecha).IsRequired();
            this.Property(p => p.Duracion).IsRequired();
            this.Property(p => p.Ubicacion).IsRequired();
            this.Property(p => p.PrecioUnitario).IsRequired();
            this.Property(p => p.PrecioTotal).IsRequired();
            this.Property(p => p.Estado).IsRequired();


            this.HasRequired(p => p.Producto).WithMany().HasForeignKey(p => p.IdProductoFk).WillCascadeOnDelete(false);
            this.HasRequired(p => p.Evento).WithMany().HasForeignKey(p => p.IdEventoFk).WillCascadeOnDelete(true);
        }
    }
    
}
