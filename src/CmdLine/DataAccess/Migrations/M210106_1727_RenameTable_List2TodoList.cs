using FluentMigrator;

namespace CmdLine.DataAccess.Migrations
{
   [Migration(210106_1727)]
   public class M210106_1727_RenameTable_List2TodoList : UpOnlyMigration
   {
      public override void Up()
      {
         Rename.Table("List").To("TodoList");
      }
   }
}
