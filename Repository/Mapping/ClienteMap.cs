using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Entidades;

namespace Repository
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            
            this.Property(p => p.Telefono).IsRequired();
            this.ToTable("Cliente");

            this.HasRequired(p => p.Ocupacion).WithMany().HasForeignKey(p => p.IdOcupacionFk).WillCascadeOnDelete(false);
        }
    }
}
