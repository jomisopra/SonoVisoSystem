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
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {

            
            this.Property(p => p.Telefono).IsRequired();
            this.Property(p => p.Contraseña).IsRequired();

            this.ToTable("Usuario");

            this.HasRequired(p => p.Cargo).WithMany().HasForeignKey(p => p.IdCargoFK).WillCascadeOnDelete(false);
        }
    }
}
