using System.Web.UI.WebControls;

namespace FirstAskisiOmadiki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSuppliersAndManyToManyRelationships : DbMigration
    {
        public override void Up()
        {
             CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SupplierId);
            
            CreateTable(
                "dbo.SupplierProducts",
                c => new
                    {
                        Supplier_SupplierId = c.Int(nullable: false),
                        Product_ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Supplier_SupplierId, t.Product_ProductId })
                .ForeignKey("dbo.Suppliers", t => t.Supplier_SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .Index(t => t.Supplier_SupplierId)
                .Index(t => t.Product_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplierProducts", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.SupplierProducts", "Supplier_SupplierId", "dbo.Suppliers");
            DropIndex("dbo.SupplierProducts", new[] { "Product_ProductId" });
            DropIndex("dbo.SupplierProducts", new[] { "Supplier_SupplierId" });
            DropTable("dbo.SupplierProducts");
            DropTable("dbo.Suppliers");
        }
    }
}
