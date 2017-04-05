namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alquiler",
                c => new
                    {
                        IdAlquiler = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAlquiler)
                .ForeignKey("dbo.Persona", t => t.ClienteId)
                .ForeignKey("dbo.Persona", t => t.UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Direccion = c.String(),
                        DNI = c.Int(nullable: false),
                        Sexo = c.String(),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DetalleAlquiler",
                c => new
                    {
                        IdProductoFk = c.Int(nullable: false),
                        IdAlquilerFk = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        PrecioTotal = c.Double(nullable: false),
                        PrecioUnitario = c.Double(nullable: false),
                        CantidadUnitaria = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdProductoFk, t.IdAlquilerFk })
                .ForeignKey("dbo.Alquiler", t => t.IdAlquilerFk, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.IdProductoFk)
                .Index(t => t.IdProductoFk)
                .Index(t => t.IdAlquilerFk);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        Anio = c.Int(nullable: false),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        Stock = c.Int(nullable: false),
                        Costo = c.Int(nullable: false),
                        FIngreso = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdProducto);
            
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        IdCategoria = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.IdCategoria);
            
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        IdArea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdArea);
            
            CreateTable(
                "dbo.Formato",
                c => new
                    {
                        IdFormato = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdFormato);
            
            CreateTable(
                "dbo.Genero",
                c => new
                    {
                        IdGenero = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdGenero);
            
            CreateTable(
                "dbo.Produccion",
                c => new
                    {
                        IdProduccion = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdProduccion);
            
            CreateTable(
                "dbo.Cargo",
                c => new
                    {
                        IdCargo = c.Int(nullable: false, identity: true),
                        NombreCargo = c.String(),
                    })
                .PrimaryKey(t => t.IdCargo);
            
            CreateTable(
                "dbo.DetalleEvento",
                c => new
                    {
                        IdProductoFk = c.Int(nullable: false),
                        IdEventoFk = c.Int(nullable: false),
                        Duracion = c.Int(nullable: false),
                        Ubicacion = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        PrecioUnitario = c.Int(nullable: false),
                        PrecioTotal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdProductoFk, t.IdEventoFk })
                .ForeignKey("dbo.Evento", t => t.IdEventoFk, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.IdProductoFk)
                .Index(t => t.IdProductoFk)
                .Index(t => t.IdEventoFk);
            
            CreateTable(
                "dbo.Evento",
                c => new
                    {
                        IdEvento = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdEvento)
                .ForeignKey("dbo.Persona", t => t.ClienteId)
                .ForeignKey("dbo.Persona", t => t.UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Ocupacion",
                c => new
                    {
                        IdOcupacion = c.Int(nullable: false, identity: true),
                        NombreOcu = c.String(),
                    })
                .PrimaryKey(t => t.IdOcupacion);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Telefono = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persona", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Material",
                c => new
                    {
                        IdProducto = c.Int(nullable: false),
                        Marca = c.String(nullable: false),
                        Modelo = c.String(nullable: false),
                        NroSerie = c.String(nullable: false),
                        IdCategoriaFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProducto)
                .ForeignKey("dbo.Producto", t => t.IdProducto)
                .ForeignKey("dbo.Categoria", t => t.IdCategoriaFK)
                .Index(t => t.IdProducto)
                .Index(t => t.IdCategoriaFK);
            
            CreateTable(
                "dbo.Medio",
                c => new
                    {
                        IdProducto = c.Int(nullable: false),
                        Produccion_IdProduccion = c.Int(),
                        Titulo = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Duracion = c.Double(nullable: false),
                        CodigoMedio = c.String(),
                        IdProduccionFK = c.Int(nullable: false),
                        IdAreaFK = c.Int(nullable: false),
                        IdGeneroFK = c.Int(nullable: false),
                        IdFormatoFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProducto)
                .ForeignKey("dbo.Producto", t => t.IdProducto)
                .ForeignKey("dbo.Produccion", t => t.Produccion_IdProduccion)
                .ForeignKey("dbo.Area", t => t.IdAreaFK)
                .ForeignKey("dbo.Genero", t => t.IdGeneroFK)
                .ForeignKey("dbo.Formato", t => t.IdFormatoFK)
                .Index(t => t.IdProducto)
                .Index(t => t.Produccion_IdProduccion)
                .Index(t => t.IdAreaFK)
                .Index(t => t.IdGeneroFK)
                .Index(t => t.IdFormatoFK);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Contraseña = c.String(nullable: false),
                        Codigo = c.String(nullable: false),
                        Cargo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persona", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "Id", "dbo.Persona");
            DropForeignKey("dbo.Medio", "IdFormatoFK", "dbo.Formato");
            DropForeignKey("dbo.Medio", "IdGeneroFK", "dbo.Genero");
            DropForeignKey("dbo.Medio", "IdAreaFK", "dbo.Area");
            DropForeignKey("dbo.Medio", "Produccion_IdProduccion", "dbo.Produccion");
            DropForeignKey("dbo.Medio", "IdProducto", "dbo.Producto");
            DropForeignKey("dbo.Material", "IdCategoriaFK", "dbo.Categoria");
            DropForeignKey("dbo.Material", "IdProducto", "dbo.Producto");
            DropForeignKey("dbo.Cliente", "Id", "dbo.Persona");
            DropForeignKey("dbo.DetalleEvento", "IdProductoFk", "dbo.Producto");
            DropForeignKey("dbo.DetalleEvento", "IdEventoFk", "dbo.Evento");
            DropForeignKey("dbo.Evento", "UsuarioId", "dbo.Persona");
            DropForeignKey("dbo.Evento", "ClienteId", "dbo.Persona");
            DropForeignKey("dbo.Alquiler", "UsuarioId", "dbo.Persona");
            DropForeignKey("dbo.DetalleAlquiler", "IdProductoFk", "dbo.Producto");
            DropForeignKey("dbo.DetalleAlquiler", "IdAlquilerFk", "dbo.Alquiler");
            DropForeignKey("dbo.Alquiler", "ClienteId", "dbo.Persona");
            DropIndex("dbo.Usuario", new[] { "Id" });
            DropIndex("dbo.Medio", new[] { "IdFormatoFK" });
            DropIndex("dbo.Medio", new[] { "IdGeneroFK" });
            DropIndex("dbo.Medio", new[] { "IdAreaFK" });
            DropIndex("dbo.Medio", new[] { "Produccion_IdProduccion" });
            DropIndex("dbo.Medio", new[] { "IdProducto" });
            DropIndex("dbo.Material", new[] { "IdCategoriaFK" });
            DropIndex("dbo.Material", new[] { "IdProducto" });
            DropIndex("dbo.Cliente", new[] { "Id" });
            DropIndex("dbo.Evento", new[] { "ClienteId" });
            DropIndex("dbo.Evento", new[] { "UsuarioId" });
            DropIndex("dbo.DetalleEvento", new[] { "IdEventoFk" });
            DropIndex("dbo.DetalleEvento", new[] { "IdProductoFk" });
            DropIndex("dbo.DetalleAlquiler", new[] { "IdAlquilerFk" });
            DropIndex("dbo.DetalleAlquiler", new[] { "IdProductoFk" });
            DropIndex("dbo.Alquiler", new[] { "ClienteId" });
            DropIndex("dbo.Alquiler", new[] { "UsuarioId" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Medio");
            DropTable("dbo.Material");
            DropTable("dbo.Cliente");
            DropTable("dbo.Ocupacion");
            DropTable("dbo.Evento");
            DropTable("dbo.DetalleEvento");
            DropTable("dbo.Cargo");
            DropTable("dbo.Produccion");
            DropTable("dbo.Genero");
            DropTable("dbo.Formato");
            DropTable("dbo.Area");
            DropTable("dbo.Categoria");
            DropTable("dbo.Producto");
            DropTable("dbo.DetalleAlquiler");
            DropTable("dbo.Persona");
            DropTable("dbo.Alquiler");
        }
    }
}
