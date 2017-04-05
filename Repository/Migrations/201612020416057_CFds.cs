namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CFds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "Telefono", c => c.Int(nullable: false));
            AddColumn("dbo.Usuario", "IdCargoFK", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuario", "IdCargoFK");
            AddForeignKey("dbo.Usuario", "IdCargoFK", "dbo.Cargo", "IdCargo");
            DropColumn("dbo.Usuario", "Codigo");
            DropColumn("dbo.Usuario", "Cargo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "Cargo", c => c.String());
            AddColumn("dbo.Usuario", "Codigo", c => c.String(nullable: false));
            DropForeignKey("dbo.Usuario", "IdCargoFK", "dbo.Cargo");
            DropIndex("dbo.Usuario", new[] { "IdCargoFK" });
            DropColumn("dbo.Usuario", "IdCargoFK");
            DropColumn("dbo.Usuario", "Telefono");
        }
    }
}
