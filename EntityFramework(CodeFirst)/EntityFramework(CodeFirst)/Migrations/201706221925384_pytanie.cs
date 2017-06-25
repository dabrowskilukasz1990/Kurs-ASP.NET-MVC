namespace EntityFramework_CodeFirst_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pytanie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kontakts", "Pytanie", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kontakts", "Pytanie");
        }
    }
}
