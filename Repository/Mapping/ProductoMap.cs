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
    public class ProductoMap : EntityTypeConfiguration<Producto>
    {
        public ProductoMap()
        {
            this.HasKey(p => p.IdProducto);
            this.Property(p => p.IdProducto).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

          
            this.ToTable("Producto"); 

            //this.HasRequired(p => p.Medio).WithMany().HasForeignKey(p => p.IdMedioFk).WillCascadeOnDelete(false);
            //this.HasRequired(p => p.Material).WithMany().HasForeignKey(p => p.IdMaterialFk).WillCascadeOnDelete(false);

        }
    }
}
