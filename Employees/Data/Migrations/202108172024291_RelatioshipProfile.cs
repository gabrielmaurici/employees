namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelatioshipProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeesInvites", "Profile_Id", c => c.Int());
            CreateIndex("dbo.EmployeesInvites", "Profile_Id");
            AddForeignKey("dbo.EmployeesInvites", "Profile_Id", "dbo.Profiles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeesInvites", "Profile_Id", "dbo.Profiles");
            DropIndex("dbo.EmployeesInvites", new[] { "Profile_Id" });
            DropColumn("dbo.EmployeesInvites", "Profile_Id");
        }
    }
}
