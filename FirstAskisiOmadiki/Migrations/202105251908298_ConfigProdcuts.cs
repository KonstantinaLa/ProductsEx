namespace FirstAskisiOmadiki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfigProdcuts : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Title", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Products", "DateModified", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "DateModified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "Title", c => c.String());
        }
    }
}
