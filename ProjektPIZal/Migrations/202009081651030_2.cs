namespace ProjektPIZal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartDTOes",
                c => new
                    {
                        CartID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CartID)
                .ForeignKey("dbo.tblUsers", t => t.CartID)
                .Index(t => t.CartID);
            
            CreateTable(
                "dbo.TeaDTOCartDTOes",
                c => new
                    {
                        TeaDTO_TeaID = c.Int(nullable: false),
                        CartDTO_CartID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeaDTO_TeaID, t.CartDTO_CartID })
                .ForeignKey("dbo.tblTeas", t => t.TeaDTO_TeaID, cascadeDelete: true)
                .ForeignKey("dbo.CartDTOes", t => t.CartDTO_CartID, cascadeDelete: true)
                .Index(t => t.TeaDTO_TeaID)
                .Index(t => t.CartDTO_CartID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartDTOes", "CartID", "dbo.tblUsers");
            DropForeignKey("dbo.TeaDTOCartDTOes", "CartDTO_CartID", "dbo.CartDTOes");
            DropForeignKey("dbo.TeaDTOCartDTOes", "TeaDTO_TeaID", "dbo.tblTeas");
            DropIndex("dbo.TeaDTOCartDTOes", new[] { "CartDTO_CartID" });
            DropIndex("dbo.TeaDTOCartDTOes", new[] { "TeaDTO_TeaID" });
            DropIndex("dbo.CartDTOes", new[] { "CartID" });
            DropTable("dbo.TeaDTOCartDTOes");
            DropTable("dbo.CartDTOes");
        }
    }
}
