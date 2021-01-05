namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenreID : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Genre_ID = 1 Where ID = 1");
        }
        
        public override void Down()
        {
        }
    }
}
