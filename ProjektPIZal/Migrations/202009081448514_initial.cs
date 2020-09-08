namespace ProjektPIZal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblTeas",
                c => new
                    {
                        TeaID = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        Photo = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.TeaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblTeas");
        }
    }
}
