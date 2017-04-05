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
    public class AreaMap:EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            this.HasKey(p => p.IdArea);
            this.Property(p => p.IdArea).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            this.ToTable("Area");

          
        }
    }
}
