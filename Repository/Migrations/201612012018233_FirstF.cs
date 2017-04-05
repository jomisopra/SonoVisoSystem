namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstF : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Medio", new[] { "Produccion_IdProduccion" });
            DropColumn("dbo.Medio", "IdProduccionFK");
            RenameColumn(table: "dbo.Medio", name: "Produccion_IdProduccion", newName: "IdProduccionFK");
            AlterColumn("dbo.Medio", "IdProduccionFK", c => c.Int(nullable: false));
            CreateIndex("dbo.Medio", "IdProduccionFK");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Medio", new[] { "IdProduccionFK" });
            AlterColumn("dbo.Medio", "IdProduccionFK", c => c.Int());
            RenameColumn(table: "dbo.Medio", name: "IdProduccionFK", newName: "Produccion_IdProduccion");
            AddColumn("dbo.Medio", "IdProduccionFK", c => c.Int(nullable: false));
            CreateIndex("dbo.Medio", "Produccion_IdProduccion");
        }
    }
}
