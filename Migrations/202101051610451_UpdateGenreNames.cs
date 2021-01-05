namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenreNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Genres Set Name = 'Comedy' WHERE ID = 1");
            Sql("UPDATE Genres Set Name = 'Action' WHERE ID = 2");
            Sql("UPDATE Genres Set Name = 'Family' WHERE ID = 3");
            Sql("UPDATE Genres Set Name = 'Romance' WHERE ID = 4");
        }
        
        public override void Down()
        {
        }
    }
}
