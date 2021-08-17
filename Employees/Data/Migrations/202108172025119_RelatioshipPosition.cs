namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelatioshipPosition : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeesInvites", "Position_Id", c => c.Int());
            CreateIndex("dbo.EmployeesInvites", "Position_Id");
            AddForeignKey("dbo.EmployeesInvites", "Position_Id", "dbo.Positions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeesInvites", "Position_Id", "dbo.Positions");
            DropIndex("dbo.EmployeesInvites", new[] { "Position_Id" });
            DropColumn("dbo.EmployeesInvites", "Position_Id");
        }
    }
}
