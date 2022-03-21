namespace SurfingRedone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beaches",
                c => new
                    {
                        BeachID = c.Int(nullable: false, identity: true),
                        BName = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.BeachID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        TName = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.Beaches");
        }
    }
}
