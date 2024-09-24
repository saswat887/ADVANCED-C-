namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mySchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.pizzabl",
                c => new
                    {
                        pid = c.Int(nullable: false),
                        pizzanames = c.String(maxLength: 50, unicode: false),
                        price = c.Int(nullable: false),
                        pizzatype = c.String(maxLength: 50, unicode: false),
                        description = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.pid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.pizzabl");
        }
    }
}
