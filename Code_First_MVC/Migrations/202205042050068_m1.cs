namespace Code_First_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String());
            AlterColumn("dbo.Employees", "Address", c => c.String());
            AlterColumn("dbo.Employees", "Email", c => c.String());
            AlterColumn("dbo.Employees", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Salary", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "Email", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "Address", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "Name", c => c.Int(nullable: false));
        }
    }
}
