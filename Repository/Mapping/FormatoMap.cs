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
   public class FormatoMap:EntityTypeConfiguration<Formato>
    {
       public FormatoMap()
        {
            this.HasKey(p => p.IdFormato);
            this.Property(p => p.IdFormato).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);



          
        }
    }
}
