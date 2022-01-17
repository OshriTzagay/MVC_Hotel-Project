namespace Exam_ExampleForTest_17_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TheGuestsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        Birthday = c.Int(nullable: false),
                        CheckedIn = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Guests");
        }
    }
}
