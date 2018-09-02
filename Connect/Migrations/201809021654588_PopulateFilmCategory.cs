namespace Connect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFilmCategory : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Animator',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Cartoonist',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Tweener',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Casting Director',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Cinematohrapher',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Executive Producer',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Film Producer',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Producation Manager',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Screen Writer',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Stunt Coordinator',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Costume Designer',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Lighting Technician',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Make-Up Artist',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Anchorman',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Video Editor',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Voice Actor',5)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Weatherman',5)");
        }
        
        public override void Down()
        {
            Sql("Delete From Vocations Where CategoryId = 5");
        }
    }
}
