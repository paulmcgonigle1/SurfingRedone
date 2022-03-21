namespace SurfingRedone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstProper : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boards",
                c => new
                    {
                        BoardID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Weight = c.Int(nullable: false),
                        ImageURL = c.String(),
                        Colour = c.String(),
                        Lesson_LessonID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.BoardID)
                .ForeignKey("dbo.Lessons", t => t.Lesson_LessonID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.Lesson_LessonID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        LessonID = c.Int(nullable: false, identity: true),
                        Length = c.String(),
                        Date = c.DateTime(nullable: false),
                        ProfilePic = c.String(),
                        Teacher_TeacherID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.LessonID)
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.Teacher_TeacherID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        Surname = c.String(),
                        ProfilePic = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lessons", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Boards", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Lessons", "Teacher_TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Boards", "Lesson_LessonID", "dbo.Lessons");
            DropIndex("dbo.Lessons", new[] { "User_UserID" });
            DropIndex("dbo.Lessons", new[] { "Teacher_TeacherID" });
            DropIndex("dbo.Boards", new[] { "User_UserID" });
            DropIndex("dbo.Boards", new[] { "Lesson_LessonID" });
            DropTable("dbo.Users");
            DropTable("dbo.Lessons");
            DropTable("dbo.Boards");
        }
    }
}
