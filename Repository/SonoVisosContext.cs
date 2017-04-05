using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Repository.Mapping;
using System.Data.Entity;
using Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Repository
{
    public class SonoVisosContext : DbContext
    {
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Material> Materiales { get; set; }
        public DbSet<Medio> Medios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<DetalleAlquiler> DetalleAlquileres { get; set; }
        public DbSet<DetalleEvento> DetalleEventos { get; set; }


        public DbSet<Area> Areas { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Formato> Formatos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Ocupacion> Ocupaciones { get; set; }
        public DbSet<Produccion> Produccions { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new AlquilerMap());
            modelBuilder.Configurations.Add(new EventoMap());
            modelBuilder.Configurations.Add(new MaterialMap());
            modelBuilder.Configurations.Add(new MedioMap());
            modelBuilder.Configurations.Add(new ProductoMap());
            modelBuilder.Configurations.Add(new DetalleAlquilerMap());
            modelBuilder.Configurations.Add(new DetalleEventoMap());
            modelBuilder.Configurations.Add(new PersonaMap());


            modelBuilder.Configurations.Add(new AreaMap());
            modelBuilder.Configurations.Add(new CargoMap());
           modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new FormatoMap());
            modelBuilder.Configurations.Add(new GeneroMap());
            modelBuilder.Configurations.Add(new OcupacionMap());
            modelBuilder.Configurations.Add(new ProduccionMap());





        }
    }
}
