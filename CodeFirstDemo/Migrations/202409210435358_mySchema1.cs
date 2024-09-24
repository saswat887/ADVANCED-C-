namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mySchema1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.pizzabl", "pizzatype");
        }
        
        public override void Down()
        {
            AddColumn("dbo.pizzabl", "pizzatype", c => c.String(maxLength: 50, unicode: false));
        }
    }
}
