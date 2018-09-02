namespace Connect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSewingCategory : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Bookbinder',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Cordwainer',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Corsetier',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Draper',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Dressmaker',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Embroiderer',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Glover',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Hatter',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Leatherworker',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Milliner',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Parachute Rigger',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Quilter',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Sail Maker',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Seamstress',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Shoemaker',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Tailor',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Taxidermist',8)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Upholsterer',8)");
        }
        
        public override void Down()
        {
            Sql("Delete From Vocations Where CategoryId = 8");
        }
    }
}
