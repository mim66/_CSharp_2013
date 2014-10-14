namespace School_CodeFirst.Migrations
{				
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {		
        public override void Up()
        {
					DropTable("dbo.Student5");

					CreateTable("dbo.Student6",
                c => new {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name			= c.String(nullable: false, maxLength: 10),
                        Surname		= c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
        }
        
        public override void Down()
        {
            DropTable("dbo.Student6");
        }
    }
}
