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
    public class MaterialMap : EntityTypeConfiguration<Material>
    {
        public MaterialMap()
        {
           

         
            this.Property(p => p.Marca).IsRequired();
            this.Property(p => p.Modelo).IsRequired();
            this.Property(p => p.NroSerie).IsRequired();
            
            this.ToTable("Material");

           this.HasRequired(p => p.Categoria).WithMany().HasForeignKey(p => p.IdCategoriaFK).WillCascadeOnDelete(false);
        }
    }
    
}
