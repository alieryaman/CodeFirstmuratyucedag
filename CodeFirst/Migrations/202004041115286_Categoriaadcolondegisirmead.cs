namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Categoriaadcolondegisirmead : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriAd", c => c.String());
            Sql("Update Kategoris set KategoriAd=Kategorisim");
            DropColumn("dbo.Kategoris", "Kategorisim");
        }

        public override void Down()
        {
            AddColumn("dbo.Kategoris", "Kategorisim", c => c.String());
            Sql("Update Kategoris set Kategorisim=KategoriAd");
            DropColumn("dbo.Kategoris", "KategoriAd");
        }
    }
}
