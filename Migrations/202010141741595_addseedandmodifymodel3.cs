namespace AceAceGroupTestApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addseedandmodifymodel3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.OneSignalApplications", newName: "OneSignalApplicationModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.OneSignalApplicationModels", newName: "OneSignalApplications");
        }
    }
}
