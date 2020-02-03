namespace Project2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Plants : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plants",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Plants");
        }
    }
}
