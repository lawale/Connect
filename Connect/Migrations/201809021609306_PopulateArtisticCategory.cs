namespace Connect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateArtisticCategory : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Vocations (Name, CategoryId) Values ('Animator',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Advertising Designer',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Art Administrator',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Baker',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Ceramics Artist',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Colorist',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Concept Artist',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Curator',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Dancer',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Event Planner',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Fashion Designer',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Fine Artist',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Floral Designer',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Graphic Designer',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Hair Stylist',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Illustrator',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Tattoo Artist',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Interior Designer',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Jewellery Designer',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Lyricist',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Party Planner',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Photographer',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Potter',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Sculptor',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Set Decorator',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Web Designer',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Wedding Planner',1)");
            Sql("Insert into Vocations (Name, CategoryId) Values ('Writer',1)");
        }
        
        public override void Down()
        {
            Sql("Delete from Vocations Where CategoryId = 1");
        }
    }
}
