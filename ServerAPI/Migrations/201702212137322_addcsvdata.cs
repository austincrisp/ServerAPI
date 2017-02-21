namespace ServerAPI.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;

    public partial class addcsvdata : DbMigration
    {
        public override void Up()
        {
            var systemPath = AppDomain.CurrentDomain.BaseDirectory + @"..\App_Data\data.csv";
            var openFile = File.ReadAllLines(systemPath);

            using (var db = new ApplicationContext())
            {
                foreach (string row in openFile)
                {
                    var data = row.Split(',');
                    Hunt newHunt = new Hunt
                    {
                        HuntNumber = data[0],
                        Name = data[1],
                        Type = data[2],
                        Permits = data[3],
                        Hunters = data[4],
                        Harvest = data[5],
                        AverageDays = data[6],
                        Success = data[7],
                    };
                    db.Hunts.Add(newHunt);
                }
                db.SaveChanges();
            }
        }
        
        public override void Down()
        {
        }
    }
}
