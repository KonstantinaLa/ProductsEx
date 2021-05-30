namespace FirstAskisiOmadiki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFluentAPI : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Suppliers", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "Name", c => c.String());
        }
    }
}
