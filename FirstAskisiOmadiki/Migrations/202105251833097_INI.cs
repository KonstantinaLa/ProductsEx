namespace FirstAskisiOmadiki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INI : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        IsExpired = c.Boolean(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
