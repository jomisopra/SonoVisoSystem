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
   public class OcupacionMap:EntityTypeConfiguration<Ocupacion>
    {
       public OcupacionMap()
        {
            this.HasKey(p => p.IdOcupacion);
            this.Property(p => p.IdOcupacion).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            this.ToTable("Ocupacion");

          
        }
    }
}
