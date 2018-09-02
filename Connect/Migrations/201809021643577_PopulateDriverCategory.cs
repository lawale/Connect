namespace Connect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDriverCategory : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Taxicab Driver',3)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Uber Driver',3)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Chauffeur',3)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Pay Driver',3)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Test Driver',3)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Delivery',3)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Bus Driver',3)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Truck Driver',3)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Motorman',3)");
        }
        
        public override void Down()
        {
            Sql("Delete From Vocations Where CategoryId = 3");
        }
    }
}
