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
    public class PersonaMap : EntityTypeConfiguration<Persona>
    {
        public PersonaMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.ToTable("Persona"); 
            //this.Property(p => p.IdClienteFk).IsOptional();
            //this.Property(p => p.IdUsuarioFk).IsOptional();
            

            //this.HasRequired(p => p.Cliente).WithMany().HasForeignKey(p => p.IdClienteFk).WillCascadeOnDelete(false);
            //this.HasRequired(p => p.Usuario).WithMany().HasForeignKey(p => p.IdUsuarioFk).WillCascadeOnDelete(false);
        }
    }
}
