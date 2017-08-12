namespace OMS.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePhotoProperty : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Photo", c => c.Binary());
        }
    }
}
