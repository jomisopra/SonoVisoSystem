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
   public class GeneroMap:EntityTypeConfiguration<Genero>
    {
       public GeneroMap()
        {
            this.HasKey(p => p.IdGenero);
            this.Property(p => p.IdGenero).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            this.ToTable("Genero");

          
        }
    }
}
