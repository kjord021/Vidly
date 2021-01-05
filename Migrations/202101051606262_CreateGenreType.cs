namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGenreType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Movies", "Genre_ID", c => c.Byte());
            CreateIndex("dbo.Movies", "Genre_ID");
            AddForeignKey("dbo.Movies", "Genre_ID", "dbo.Genres", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre_Name", c => c.String());
            DropForeignKey("dbo.Movies", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_ID" });
            DropColumn("dbo.Movies", "Genre_ID");
            DropTable("dbo.Genres");
        }
    }
}
