namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelatioshipTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeesInvites", "Team_Id", c => c.Int());
            CreateIndex("dbo.EmployeesInvites", "Team_Id");
            AddForeignKey("dbo.EmployeesInvites", "Team_Id", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeesInvites", "Team_Id", "dbo.Teams");
            DropIndex("dbo.EmployeesInvites", new[] { "Team_Id" });
            DropColumn("dbo.EmployeesInvites", "Team_Id");
        }
    }
}
