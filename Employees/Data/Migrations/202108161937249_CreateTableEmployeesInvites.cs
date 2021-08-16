namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableEmployeesInvites : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeesInvites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        State = c.String(),
                        Description = c.String(),
                        Fullname = c.String(),
                        EmailAdress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeesInvites");
        }
    }
}
