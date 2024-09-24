namespace CodeFirstAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mySchema3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        DeptName = c.String(maxLength: 20),
                        Manager = c.String(maxLength: 20),
                        DepartmentEdit = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DeptId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpId = c.String(nullable: false, maxLength: 10),
                        EmpName = c.String(maxLength: 20),
                        Salary = c.Int(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        DeptId_DeptId = c.Int(),
                    })
                .PrimaryKey(t => t.EmpId)
                .ForeignKey("dbo.Departments", t => t.DeptId_DeptId)
                .Index(t => t.DeptId_DeptId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DeptId_DeptId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DeptId_DeptId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
