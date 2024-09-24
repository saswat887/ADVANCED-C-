namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mySchema2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.pizzabl", "pizzasize", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.pizzabl", "pizzasize");
        }
    }
}
