namespace Connect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserPhotoProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DisplayPhoto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DisplayPhoto");
        }
    }
}
