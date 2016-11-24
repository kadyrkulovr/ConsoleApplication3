namespace ConsoleApplication3.DocumentMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDocument : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Document.Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("User.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            /*
             * EF пытается создать таблицу в схеме User,
             * Но она уже создана другой миграцией (UserMigrations)
             * поэтому выходит ошибка - There is already an object named 'Users' in the database.
             * Как объяснить EF чтобы чтобы он не создавал эту таблицу?
             */
            CreateTable(
                "User.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Document.Documents", "UserId", "User.Users");
            DropIndex("Document.Documents", new[] { "UserId" });
            DropTable("User.Users");
            DropTable("Document.Documents");
        }
    }
}
