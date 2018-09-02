namespace Connect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateComputerCategory : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Application Analyst',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Computer Operator',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Computer Repair Technician',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Computer Scientist',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Computer Analyst',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Data Entry Clerk',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Database Administrator',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Data Analyst',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Data Scientist',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Network Analyst',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Network Administrator',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Programmer',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Paralegal',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Security Engineer',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Software Analyst',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Software Design',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Software Engineer',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Software Quality Analyst',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Software Administrator',2)");
            Sql("Insert Into Vocations (Name,CategoryId) Values ('Web Developer',2)");
        }
        
        public override void Down()
        {
            Sql("Delete From Vocations where CategoryId = 2");
        }
    }
}
