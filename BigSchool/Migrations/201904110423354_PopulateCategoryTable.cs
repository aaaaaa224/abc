namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Categories(Id, Name) values(1, 'Web')");
            Sql("insert into Categories(Id, Name) values(2, 'Android')");
            Sql("insert into Categories(Id, Name) values(3, 'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
