namespace EntityFramework_CodeFirst_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class nowaTabelaOdpowiedz : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Odpowiedzs",
                c => new
                {
                    OdpowiedzId = c.Int(nullable: false, identity: true),
                    Odp = c.String(),
                    Pytanie = c.String(),
                })
                .PrimaryKey(t => t.OdpowiedzId);
        }

        public override void Down()
        {

            DropTable("dbo.Odpowiedzs");
        }
    }
}
