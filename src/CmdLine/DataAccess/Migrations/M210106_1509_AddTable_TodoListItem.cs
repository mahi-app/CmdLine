using FluentMigrator;

namespace CmdLine.DataAccess.Migrations
{
   [Migration(210106_1509)]
   public class M210106_1509_AddTable_TodoListItem : UpOnlyMigration
   {
      public override void Up()
      {
         const string tableName = "TodoListItem";
         const string todoListIdColumn = "TodoListId";
         Create.Table(tableName)
            .WithColumn("Id").AsGuid().NotNullable().PrimaryKey()
            .WithColumn(todoListIdColumn).AsGuid().NotNullable()
            .WithColumn("Title").AsString().NotNullable()
            ;
         Create.Index($"IDX_{tableName}_{todoListIdColumn}")
            .OnTable(tableName)
            .OnColumn(todoListIdColumn)
            ;
      }
   }
}
