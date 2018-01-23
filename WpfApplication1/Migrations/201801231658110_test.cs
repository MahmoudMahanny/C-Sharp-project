namespace WpfApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Instructors", "phone_Number", c => c.Int());
            AlterColumn("dbo.Students", "phone_Number", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "phone_Number", c => c.Int(nullable: false));
            AlterColumn("dbo.Instructors", "phone_Number", c => c.Int(nullable: false));
        }
    }
}
