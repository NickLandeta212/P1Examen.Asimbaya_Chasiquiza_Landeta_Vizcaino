namespace P1Examen.Asimbaya_Chasiquiza_Landeta_Vizcaino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Armaduras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nombreArmadura = c.String(nullable: false),
                        tipoArmadura = c.String(),
                        resistencia = c.Int(nullable: false),
                        caballeroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Caballeroes", t => t.caballeroId, cascadeDelete: true)
                .Index(t => t.caballeroId);
            
            CreateTable(
                "dbo.Caballeroes",
                c => new
                    {
                        caballeroId = c.Int(nullable: false, identity: true),
                        caballeroName = c.String(nullable: false),
                        constelacion = c.String(),
                        nivelPoder = c.Int(nullable: false),
                        elemento = c.String(),
                    })
                .PrimaryKey(t => t.caballeroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Armaduras", "caballeroId", "dbo.Caballeroes");
            DropIndex("dbo.Armaduras", new[] { "caballeroId" });
            DropTable("dbo.Caballeroes");
            DropTable("dbo.Armaduras");
        }
    }
}
