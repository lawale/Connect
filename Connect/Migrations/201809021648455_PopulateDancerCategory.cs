namespace Connect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDancerCategory : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Ballet Dancer',4)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Backup Dancer',4)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Choreographer',4)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Dancer',4)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Dance Therapy',4)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Exotic Dancer',4)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Repetiteur',4)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Show Girl',4)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Dance Journalist',4)");
        }
        
        public override void Down()
        {
            Sql("Delete From Vocations Where CategoryId = 4");
        }
    }
}
