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
    public class DetalleAlquilerMap: EntityTypeConfiguration<DetalleAlquiler>
    {
        public DetalleAlquilerMap()
        {
            this.HasKey(p => new { p.IdProductoFk,p.IdAlquilerFk });
            

            this.Property(p => p.Fecha).IsRequired();
            this.Property(p => p.PrecioTotal).IsRequired();
            this.Property(p => p.PrecioUnitario).IsRequired();
            this.Property(p => p.CantidadUnitaria).IsRequired();
            this.Property(p =>p.Estado).IsRequired();
     

            this.HasRequired(p => p.Producto).WithMany(p => p.DetalleAlquileres).HasForeignKey(p => p.IdProductoFk).WillCascadeOnDelete(false);
            this.HasRequired(p => p.Alquiler).WithMany(p => p.DetalleAlquileres).HasForeignKey(p => p.IdAlquilerFk).WillCascadeOnDelete(true);
        }
    }
        }

