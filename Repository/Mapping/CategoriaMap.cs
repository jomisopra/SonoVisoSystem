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
    public class CategoriaMap:EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            this.HasKey(p => p.IdCategoria);
            this.Property(p => p.IdCategoria).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            this.ToTable("Categoria");
          
        }
    }
}
