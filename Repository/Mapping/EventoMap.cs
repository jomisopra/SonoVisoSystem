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
    public class EventoMap : EntityTypeConfiguration<Evento>
    {
        public EventoMap()
        {
            this.HasKey(p => p.IdEvento);
            this.Property(p => p.IdEvento).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Nombre).IsRequired();


            this.HasRequired(p => p.Usuario).WithMany().HasForeignKey(p => p.UsuarioId).WillCascadeOnDelete(false);
            this.HasRequired(p => p.Cliente).WithMany().HasForeignKey(p => p.ClienteId).WillCascadeOnDelete(false);
        }
    }

}
