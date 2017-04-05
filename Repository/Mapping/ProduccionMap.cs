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
   public class ProduccionMap:EntityTypeConfiguration<Produccion>
    {
       public ProduccionMap()
        {
            this.HasKey(p => p.IdProduccion);
            this.Property(p => p.IdProduccion).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            this.ToTable("Produccion");

          
        }
    }
}
