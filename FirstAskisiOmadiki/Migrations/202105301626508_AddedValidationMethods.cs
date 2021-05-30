namespace FirstAskisiOmadiki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedValidationMethods : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "DateModified", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "DateModified", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
