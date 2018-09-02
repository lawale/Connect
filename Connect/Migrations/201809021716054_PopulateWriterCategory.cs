namespace Connect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateWriterCategory : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Author',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('BLogger',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Book Coach',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Commissioning Editor',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Copy Editor',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Creative Consultant',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Free Lancer',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Ghost Writer',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Griot',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Hack Writer',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Infopreneur',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Journalist',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Literary Editor',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Manuscript Format',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Medical Writing',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Novelist',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Poet',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Polygraph',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Review',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Scribe',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Script Coordinator',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Script Doctor',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Script Doctor',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Scrivener',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Song Writer',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Speech Writer',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Staff Writer',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Technical Writer',6)");
            Sql("Insert Into Vocations (Name, CategoryId) Values ('Website Content Writer',6)");
        }
        
        public override void Down()
        {
            Sql("Delete From Vocations Where CategoryId = 6");
        }
    }
}
