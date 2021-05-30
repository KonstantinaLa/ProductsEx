namespace FirstAskisiOmadiki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFluentAPIAgain : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SupplierProducts", newName: "SuppliersProducts");
            RenameColumn(table: "dbo.SuppliersProducts", name: "Supplier_SupplierId", newName: "SupplierId");
            RenameColumn(table: "dbo.SuppliersProducts", name: "Product_ProductId", newName: "ProductId");
            RenameIndex(table: "dbo.SuppliersProducts", name: "IX_Supplier_SupplierId", newName: "IX_SupplierId");
            RenameIndex(table: "dbo.SuppliersProducts", name: "IX_Product_ProductId", newName: "IX_ProductId");
            AlterColumn("dbo.Suppliers", "Name", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "Name", c => c.String(nullable: false));
            RenameIndex(table: "dbo.SuppliersProducts", name: "IX_ProductId", newName: "IX_Product_ProductId");
            RenameIndex(table: "dbo.SuppliersProducts", name: "IX_SupplierId", newName: "IX_Supplier_SupplierId");
            RenameColumn(table: "dbo.SuppliersProducts", name: "ProductId", newName: "Product_ProductId");
            RenameColumn(table: "dbo.SuppliersProducts", name: "SupplierId", newName: "Supplier_SupplierId");
            RenameTable(name: "dbo.SuppliersProducts", newName: "SupplierProducts");
        }
    }
}
