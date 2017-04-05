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
    public class MedioMap : EntityTypeConfiguration<Medio>
    {
        public MedioMap()
        {
            

            this.Property(p => p.Titulo).IsRequired();
            this.Property(p => p.Descripcion).IsRequired();
      
            this.Property(p => p.Duracion).IsRequired();

            this.ToTable("Medio");

            this.HasRequired(p => p.Produccion).WithMany().HasForeignKey(p => p.IdProduccionFK).WillCascadeOnDelete(false);
            this.HasRequired(p => p.Area).WithMany().HasForeignKey(p => p.IdAreaFK).WillCascadeOnDelete(false);
            this.HasRequired(p => p.Genero).WithMany().HasForeignKey(p => p.IdGeneroFK).WillCascadeOnDelete(false);
            this.HasRequired(p => p.Formato).WithMany().HasForeignKey(p => p.IdFormatoFK).WillCascadeOnDelete(false);
        }
    }
}
