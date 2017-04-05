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
    public class CargoMap:EntityTypeConfiguration<Cargo>
    {
        public CargoMap()
        {
            this.HasKey(p => p.IdCargo);
            this.Property(p => p.IdCargo).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            this.ToTable("Cargo");

          
        }
    }
}
