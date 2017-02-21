namespace ServerAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedHuntIdToHuntNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hunts", "HuntNumber", c => c.String());
            AlterColumn("dbo.Hunts", "Permits", c => c.String());
            AlterColumn("dbo.Hunts", "Hunters", c => c.String());
            AlterColumn("dbo.Hunts", "Harvest", c => c.String());
            AlterColumn("dbo.Hunts", "AverageDays", c => c.String());
            AlterColumn("dbo.Hunts", "Success", c => c.String());
            DropColumn("dbo.Hunts", "HuntId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hunts", "HuntId", c => c.Int(nullable: false));
            AlterColumn("dbo.Hunts", "Success", c => c.Double(nullable: false));
            AlterColumn("dbo.Hunts", "AverageDays", c => c.Double(nullable: false));
            AlterColumn("dbo.Hunts", "Harvest", c => c.Int(nullable: false));
            AlterColumn("dbo.Hunts", "Hunters", c => c.Int(nullable: false));
            AlterColumn("dbo.Hunts", "Permits", c => c.Int(nullable: false));
            DropColumn("dbo.Hunts", "HuntNumber");
        }
    }
}
