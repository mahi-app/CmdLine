using FluentMigrator;

namespace CmdLine.DataAccess.Migrations
{
    [Migration(201109_0935)]
    public class M201109_0935_AddTable_List : Migration
    {
        public override void Down()
        {
            throw new System.NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("List")
                .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString().NotNullable()
                ;
        }
    }
}
