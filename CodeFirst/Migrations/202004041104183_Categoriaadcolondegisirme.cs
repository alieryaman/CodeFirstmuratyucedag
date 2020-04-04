namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categoriaadcolondegisirme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategorAdi", c => c.String());
            DropColumn("dbo.Kategoris", "Kategoriisim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "Kategoriisim", c => c.String());
            DropColumn("dbo.Kategoris", "KategorAdi");
        }
    }
}
