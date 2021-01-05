namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, Stock) VALUES ('Hangover', 'Comedy', 10/20/2009, 10/21/2009, 15)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, Stock) VALUES ('Die Hard', 'Action', 10/20/2009, 10/21/2009, 14)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, Stock) VALUES ('The Terminator', 'Action', 10/20/2009, 10/21/2009, 16)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, Stock) VALUES ('Toy Story', 'Family', 10/20/2009, 10/21/2009, 21)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, Stock) VALUES ('Titanic', 'Romance', 10/20/2009, 10/21/2009, 17)");


        }

        public override void Down()
        {
        }
    }
}
