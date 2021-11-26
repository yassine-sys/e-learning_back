namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data15 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Options", "QuesId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Options", "QuesId", c => c.Int(nullable: false));
        }
    }
}
