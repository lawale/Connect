namespace Connect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategories : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Categories (Name) Values ('Artistic')");
            Sql("Insert Into Categories (Name) Values ('Computer')");
            Sql("Insert Into Categories (Name) Values ('Driver')");
            Sql("Insert Into Categories (Name) Values ('Dancer')");
            Sql("Insert Into Categories (Name) Values ('Film')");
            Sql("Insert Into Categories (Name) Values ('Writer')");
            Sql("Insert Into Categories (Name) Values ('Technical')");
            Sql("Insert Into Categories (Name) Values ('Sewing')");
        }
        
        public override void Down()
        {
            Sql("Delete From Categories Where Id In (1,2,3,4,5,6,7,8) ");
        }
    }
}
