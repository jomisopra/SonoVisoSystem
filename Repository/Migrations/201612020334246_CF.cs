namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "IdOcupacionFk", c => c.Int(nullable: false));
            CreateIndex("dbo.Cliente", "IdOcupacionFk");
            AddForeignKey("dbo.Cliente", "IdOcupacionFk", "dbo.Ocupacion", "IdOcupacion");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "IdOcupacionFk", "dbo.Ocupacion");
            DropIndex("dbo.Cliente", new[] { "IdOcupacionFk" });
            DropColumn("dbo.Cliente", "IdOcupacionFk");
        }
    }
}
