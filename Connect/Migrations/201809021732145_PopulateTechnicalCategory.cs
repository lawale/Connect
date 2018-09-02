namespace Connect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTechnicalCategory : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Auto Mechanic',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Beader',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Foreman',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Maintenance Engineer',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Mechanic',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Miller',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Moldmaker',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Panel Beater',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Pattern Maker',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Plant Operator',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Plumber',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Welder',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Sawfiler',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Shop Foreman',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Soaper',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Stationary Engineer',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Wheelwright',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Woodworkers',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Bartender',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Waiter',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Construction Worker',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Cashier',7)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Factory Worker',7)");
        }
        
        public override void Down()
        {
            Sql("Delete From Vocations Where CategoryId = 7");
        }
    }
}
