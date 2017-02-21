namespace ServerAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedHuntId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hunts", "HuntId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hunts", "HuntId");
        }
    }
}
