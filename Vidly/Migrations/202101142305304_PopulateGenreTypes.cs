namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Action')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Thriller')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Horror')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
