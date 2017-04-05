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
    public class AlquilerMap : EntityTypeConfiguration<Alquiler>
    {
        public AlquilerMap()
        {
            this.HasKey(p => p.IdAlquiler);
            this.Property(p => p.IdAlquiler).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Fecha).IsRequired();

            this.HasRequired(p => p.Usuario).WithMany().HasForeignKey(p => p.UsuarioId).WillCascadeOnDelete(false);

            this.HasRequired(p => p.Cliente).WithMany().HasForeignKey(p => p.ClienteId).WillCascadeOnDelete(false);
        }
    }
}
