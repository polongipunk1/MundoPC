namespace Mundo_PC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellidos = c.String(),
                        correo = c.String(),
                        usuario = c.String(),
                        password = c.String(),
                        direccion = c.String(),
                        colonia = c.String(),
                        region = c.String(),
                        cp = c.Int(nullable: false),
                        telefono = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.usuarios");
        }
    }
}
